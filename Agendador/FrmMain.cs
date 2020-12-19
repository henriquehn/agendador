using Agendador.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agendador
{
    public partial class FrmMain : Form
    {
        private EditMode currentMode = EditMode.None;
        private readonly SortedSet<AlarmEvent> CurrentEvents = new SortedSet<AlarmEvent>();
        public AlarmEvent SelectedValue { get; private set; } = null;
        public AlarmEvent[] SelectedValues { get; private set; } = { };
        private System.Threading.Timer timer = null;
        private readonly string filename = GetFileName();
        private readonly EventViwer frmEventViwer = new EventViwer();

        private static string GetFileName()
        {
            var parts = Application.ExecutablePath.Split('\\');
            parts[parts.GetUpperBound(0)] = "config.json";
            return String.Join("\\", parts);
        }

        private EditMode CurrentMode
        {
            get
            {
                return currentMode;
            }
            set
            {
                if (currentMode!=value)
                {
                    currentMode = value;
                    UpdateControls();
                }
            }
        }


        private void UpdateControls()
        {
            gridEvents.Enabled = currentMode == EditMode.None || currentMode.Contains(EditMode.CanAdd, EditMode.CanEdit, EditMode.CanDelete);
            cmdAdd.Enabled = currentMode.Contains(EditMode.CanAdd);
            cmdEdit.Enabled = currentMode.Contains(EditMode.CanEdit);
            cmdDelete.Enabled = currentMode.Contains(EditMode.CanDelete);
            cmdCancel.Enabled = currentMode.Contains(EditMode.IsEditing ,EditMode.IsAdding);
            cmdSave.Enabled = currentMode.Contains(EditMode.CanSave);
            txtDescription.Enabled = cmdCancel.Enabled;
            dtpAlarm.Enabled = cmdCancel.Enabled;
            dtpEvent.Enabled = cmdCancel.Enabled;
        }

        public FrmMain()
        {
            InitializeComponent();
        }

        private void Dtp_ValueChanged(object sender, EventArgs e)
        {
            if (((Control)sender).Enabled)
            {
                UpdateMode();
            }
        }

        private void TxtDescription_TextChanged(object sender, EventArgs e)
        {
            if (((Control)sender).Enabled)
            {
                UpdateMode();
            }
        }

        private void GridEvents_SelectionChanged(object sender, EventArgs e)
        {
            List<AlarmEvent> result = new List<AlarmEvent>();
            foreach (DataGridViewRow item in gridEvents.SelectedRows)
            {
                var element = CurrentEvents.ElementAt(item.Index);
                result.Add(element);
            }
            SelectedValues = result.ToArray();
            if (result.Count == 1)
            {
                SelectedValue = result[0];
            }

            if (((Control)sender).Enabled)
            {
                UpdateMode();
            }
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            if (((Control)sender).Enabled)
            {
                this.CurrentMode = EditMode.IsAdding;
                UpdateMode();
                ClearFields();
            }
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            if (((Control)sender).Enabled && SelectedValue != null)
            {
                foreach(var item in SelectedValues)
                {
                    CurrentEvents.Remove(item);
                }
                ResetMode();
            }
        }

        private void CmdEdit_Click(object sender, EventArgs e)
        {
            if (((Control)sender).Enabled)
            {
                CurrentMode = EditMode.IsEditing;
                ShowSelection();
                UpdateMode();
            }
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            if (((Control)sender).Enabled)
            {
                ResetMode();
            }
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            if (((Control)sender).Enabled)
            {
                var tempValue = new AlarmEvent(dtpAlarm.Value, dtpEvent.Value, txtDescription.Text.SafeTrim());
                if (CurrentMode.Contains(EditMode.IsAdding))
                {
                    if (CurrentEvents.Contains(tempValue))
                    {
                        MessageBox.Show("Já existe outro evento exatamente igual a esse. Não épermitido criar eventos duplicados.", "Item duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        CurrentEvents.Add(tempValue);
                    }
                }
                else if (CurrentMode.Contains(EditMode.IsEditing) && SelectedValue != null)
                {
                    if (CurrentEvents.Contains(tempValue) && !tempValue.Equals(SelectedValue))
                    {
                        if (MessageBox.Show("Já existe outro evento exatamente igual a esse. Deseja excluir o evento atual?", "Item duplicado",  MessageBoxButtons.YesNo , MessageBoxIcon.Question )== DialogResult.Yes)
                        {
                            CurrentEvents.Remove(SelectedValue);
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        CurrentEvents.Remove(SelectedValue);
                        CurrentEvents.Add(tempValue);
                        SelectedValue = tempValue;
                    }
                }
                else
                {
                    return;
                }
                SaveToFile();
                ResetMode();
                CheckTime();
                //gridEvents.Refresh();
            }
        }

        private void ResetMode()
        {
            CurrentMode = EditMode.None;
            ClearFields();
            UpdateGrid();
            UpdateMode();
        }

        private void UpdateGrid()
        {
            gridEvents.DataSource = this.CurrentEvents.ToArray();
            gridEvents.Refresh();
        }

        private void ClearFields()
        {
            txtDescription.Text = "";
            dtpAlarm.Value = DateTime.Now;
            dtpEvent.Value = DateTime.Now;
        }

        private void ShowSelection()
        {
            txtDescription.Text = SelectedValue.Description;
            dtpAlarm.Value = SelectedValue.AlarmTime;
            dtpEvent.Value = SelectedValue.EventTime;
        }

        private void UpdateMode()
        {
            if (currentMode == EditMode.None || currentMode.Contains(EditMode.CanEdit, EditMode.CanAdd))
            {
                if (SelectedValues.Length < 1)
                {
                    this.CurrentMode = EditMode.CanAdd;
                }
                else if (SelectedValue != null)
                {
                    this.CurrentMode = EditMode.CanEdit | EditMode.CanDelete | EditMode.CanAdd;
                    dtpAlarm.Value = SelectedValue.AlarmTime;
                    dtpEvent.Value = SelectedValue.EventTime;
                    txtDescription.Text = SelectedValue.Description.SafeTrim();
                }
                else if (gridEvents.SelectedRows.Count > 1)
                {
                    this.CurrentMode = EditMode.CanDelete | EditMode.CanAdd;
                }
            }
            else if (CurrentMode.Contains(EditMode.IsAdding, EditMode.IsEditing))
            {
                if (!String.IsNullOrEmpty(txtDescription.Text))
                {
                    CurrentMode = currentMode | EditMode.CanSave;
                }
                else
                {
                    CurrentMode = currentMode & ~EditMode.CanSave;
                }
            }
            UpdateControls();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadFromFile();
            frmEventViwer.OnDiscard += FrmEventViwer_OnDiscard;
            frmEventViwer.OnChange += FrmEventViwer_OnChange;
            ResetMode();
            CheckTime();
        }

        private void FrmEventViwer_OnChange(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                EventHandler caller = new EventHandler(FrmEventViwer_OnChange);
                this.Invoke(caller, sender, e);
            }
            else
            {
                if (frmEventViwer.EventCount < 1)
                {
                    statulLabel.Text = "Nenhum alarme vencido";
                    statulLabel.ForeColor = Color.Red;
                }
                else
                {
                    statulLabel.Text = string.Format("Alarme vencidos: {0}", frmEventViwer.EventCount);
                    statulLabel.ForeColor = SystemColors.WindowText;
                }
            }
        }

        private void FrmEventViwer_OnDiscard(object sender, AlarmEvent e)
        {
            if (InvokeRequired)
            {
                EventHandler<AlarmEvent> caller = new EventHandler<AlarmEvent>(FrmEventViwer_OnDiscard);
                this.Invoke(caller, sender, e);
            }
            else
            {

                try
                {
                    CurrentEvents.Remove(e);
                    SaveToFile();
                    UpdateGrid();
                }
                catch { }
            }
        }

        private void GridEvents_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            switch(e.ColumnIndex)
            {
                case 0:
                case 1:
                    DateTime time = (DateTime)e.Value;
                    e.Value = time.ToString("HH:mm:ss");
                    break;
            }
        }

        private void CheckTime()
        {
            if (timer != null)
            {
                timer.Dispose();
                timer = null;
            }

            List<AlarmEvent> found = new List<AlarmEvent>();
            AlarmEvent lastItem = null;
            bool hasNewAlarm = false;
            this.frmEventViwer.Clear();
            foreach (var item in CurrentEvents.ToArray())
            {
                if (item.AlarmTime<=DateTime.Now)
                {
                    this.frmEventViwer.Append(item);
                    hasNewAlarm = true;
                }
                else
                {
                    lastItem = item;
                    break;
                }
            }
            if (lastItem!=null)
            {
                var diff = lastItem.AlarmTime - DateTime.Now;
                timer = new System.Threading.Timer(On_Timer, null, TimeSpan.FromMilliseconds(0), diff);
            }
            if (hasNewAlarm)
            {
                this.frmEventViwer.Show();
            }
        }

        private void On_Timer(object state)
        {
            if (InvokeRequired)
            {
                Action<object> caller = new Action<object>(On_Timer);
                this.Invoke(caller, state);
            }
            else
            {
                CheckTime();
            }
        }

        private void SaveToFile()
        {
            try
            {
                string data = JsonConvert.SerializeObject(CurrentEvents);
                File.WriteAllText(filename, data, Encoding.UTF8);
            }
            catch
            {
                MessageBox.Show(string.Format("Não foi possível gravar os dados. Verifique se o arquivo \"{0}\" não está em uso.", filename), "Impossível gravar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFromFile()
        {
            try
            {
                string data = File.ReadAllText(filename);
                List<AlarmEvent> savedEvents = JsonConvert.DeserializeObject<List<AlarmEvent>>(data);
                CurrentEvents.Clear();
                foreach (var item in savedEvents)
                {
                    CurrentEvents.Add(item);
                }
            }
            catch (Exception) { }
        }

        private void StatulLabel_Click(object sender, EventArgs e)
        {
            frmEventViwer.Show();
        }
    }
}
