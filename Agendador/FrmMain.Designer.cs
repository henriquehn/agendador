namespace Agendador
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridEvents = new System.Windows.Forms.DataGridView();
            this.AlarmTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpEvent = new System.Windows.Forms.DateTimePicker();
            this.dtpAlarm = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statulLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridEvents)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridEvents
            // 
            this.gridEvents.AllowUserToAddRows = false;
            this.gridEvents.AllowUserToDeleteRows = false;
            this.gridEvents.AllowUserToOrderColumns = true;
            this.gridEvents.AllowUserToResizeColumns = false;
            this.gridEvents.AllowUserToResizeRows = false;
            this.gridEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlarmTime,
            this.EventTime,
            this.Description});
            this.gridEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEvents.Location = new System.Drawing.Point(219, 0);
            this.gridEvents.Name = "gridEvents";
            this.gridEvents.ReadOnly = true;
            this.gridEvents.RowHeadersWidth = 25;
            this.gridEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEvents.Size = new System.Drawing.Size(385, 359);
            this.gridEvents.TabIndex = 0;
            this.gridEvents.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridEvents_CellFormatting);
            this.gridEvents.SelectionChanged += new System.EventHandler(this.GridEvents_SelectionChanged);
            // 
            // AlarmTime
            // 
            this.AlarmTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AlarmTime.DataPropertyName = "AlarmTime";
            this.AlarmTime.HeaderText = "Alarme";
            this.AlarmTime.Name = "AlarmTime";
            this.AlarmTime.ReadOnly = true;
            this.AlarmTime.Width = 64;
            // 
            // EventTime
            // 
            this.EventTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EventTime.DataPropertyName = "EventTime";
            this.EventTime.HeaderText = "Evento";
            this.EventTime.Name = "EventTime";
            this.EventTime.ReadOnly = true;
            this.EventTime.Width = 66;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Descrição";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.dtpEvent);
            this.panel1.Controls.Add(this.dtpAlarm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(219, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 359);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.cmdCancel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cmdSave, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(16, 220);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(185, 62);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdCancel.Enabled = false;
            this.cmdCancel.Image = global::Agendador.Properties.Resources.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(3, 3);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(86, 56);
            this.cmdCancel.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cmdCancel, "Cancelar edição");
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdSave.Enabled = false;
            this.cmdSave.Image = global::Agendador.Properties.Resources.Save;
            this.cmdSave.Location = new System.Drawing.Point(95, 3);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(87, 56);
            this.cmdSave.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmdSave, "Salvar evento");
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.cmdEdit, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmdDelete, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmdAdd, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 285);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(185, 62);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // cmdEdit
            // 
            this.cmdEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdEdit.Enabled = false;
            this.cmdEdit.Image = global::Agendador.Properties.Resources.Edit;
            this.cmdEdit.Location = new System.Drawing.Point(125, 3);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(57, 56);
            this.cmdEdit.TabIndex = 6;
            this.toolTip1.SetToolTip(this.cmdEdit, "Editar Evento");
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.CmdEdit_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdDelete.Enabled = false;
            this.cmdDelete.Image = global::Agendador.Properties.Resources.Delete;
            this.cmdDelete.Location = new System.Drawing.Point(64, 3);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(55, 56);
            this.cmdDelete.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cmdDelete, "Excluir evento");
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdAdd.Enabled = false;
            this.cmdAdd.Image = global::Agendador.Properties.Resources.Add;
            this.cmdAdd.Location = new System.Drawing.Point(3, 3);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(55, 56);
            this.cmdAdd.TabIndex = 4;
            this.toolTip1.SetToolTip(this.cmdAdd, "Novo evento");
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.Location = new System.Drawing.Point(16, 122);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(185, 95);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.TextChanged += new System.EventHandler(this.TxtDescription_TextChanged);
            // 
            // dtpEvent
            // 
            this.dtpEvent.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpEvent.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEvent.Location = new System.Drawing.Point(16, 76);
            this.dtpEvent.Name = "dtpEvent";
            this.dtpEvent.Size = new System.Drawing.Size(185, 20);
            this.dtpEvent.TabIndex = 1;
            // 
            // dtpAlarm
            // 
            this.dtpAlarm.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpAlarm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAlarm.Location = new System.Drawing.Point(16, 30);
            this.dtpAlarm.Name = "dtpAlarm";
            this.dtpAlarm.Size = new System.Drawing.Size(185, 20);
            this.dtpAlarm.TabIndex = 1;
            this.dtpAlarm.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Horário do Evento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Horário do Alarme:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(219, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 359);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statulLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 359);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(604, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statulLabel
            // 
            this.statulLabel.Name = "statulLabel";
            this.statulLabel.Size = new System.Drawing.Size(138, 17);
            this.statulLabel.Text = "Nenhum alarme vencido";
            this.statulLabel.Click += new System.EventHandler(this.StatulLabel_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 381);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.gridEvents);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.MinimumSize = new System.Drawing.Size(620, 420);
            this.Name = "FrmMain";
            this.Text = "Gerenciar Alaemes";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEvents)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridEvents;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEvent;
        private System.Windows.Forms.DateTimePicker dtpAlarm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button cmdEdit;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlarmTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statulLabel;
    }
}

