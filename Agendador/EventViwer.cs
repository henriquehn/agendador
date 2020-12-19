using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Agendador
{
    public partial class EventViwer : Form
    {
        private readonly List<AlarmEvent> raisedEvents = new List<AlarmEvent>();
        public event EventHandler<AlarmEvent> OnDiscard;
        public event EventHandler OnChange;

        public EventViwer()
        {
            InitializeComponent();
        }

        public int EventCount
        {
            get { return raisedEvents.Count; }
        }

        public void Append(AlarmEvent item)
        {
            if (InvokeRequired)
            {
                Action<AlarmEvent> caller = new Action<AlarmEvent>(Append);
                this.Invoke(caller, item);
            }
            else
            {
                raisedEvents.Add(item);
                RefreshGrid();
                OnChange?.Invoke(this, EventArgs.Empty);
            }
        }

        public void Clear()
        {
            if (InvokeRequired)
            {
                Action caller = new Action(Clear);
                this.Invoke(caller);
            }
            else
            {
                foreach (var item in raisedEvents.ToArray())
                {
                    OnDiscard?.Invoke(this, item);
                }
                raisedEvents.Clear();
                RefreshGrid();
                OnChange?.Invoke(this, EventArgs.Empty);
            }
        }

        public void Remove(AlarmEvent item)
        {
            if (InvokeRequired)
            {
                Action<AlarmEvent> caller = new Action<AlarmEvent>(Remove);
                this.Invoke(caller, item);
            }
            else
            {

                OnDiscard?.Invoke(this, item);
                raisedEvents.Remove(item);
                RefreshGrid();
                OnChange?.Invoke(this, EventArgs.Empty);
            }
        }

        private void EventViwer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void RefreshGrid()
        {
            gridEvents.DataSource = raisedEvents.ToArray();
            gridEvents.Refresh();
        }

        private void GridEvents_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                using (DataGridViewRow item = gridEvents.SelectedRows[0])
                {
                    var removed = raisedEvents[item.Index];
                    Remove(removed);
                }
            }
            catch { }
        }
    }
}
