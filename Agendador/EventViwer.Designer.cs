namespace Agendador
{
    partial class EventViwer
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.descartarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minutosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minutosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.horaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.horasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.horasToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.horasToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.horasToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridEvents = new System.Windows.Forms.DataGridView();
            this.AlarmTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descartarToolStripMenuItem,
            this.adiarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(124, 48);
            // 
            // descartarToolStripMenuItem
            // 
            this.descartarToolStripMenuItem.Name = "descartarToolStripMenuItem";
            this.descartarToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.descartarToolStripMenuItem.Text = "Descartar";
            // 
            // adiarToolStripMenuItem
            // 
            this.adiarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minutosToolStripMenuItem,
            this.minutosToolStripMenuItem1,
            this.minutosToolStripMenuItem2,
            this.horaToolStripMenuItem,
            this.horasToolStripMenuItem,
            this.horasToolStripMenuItem1,
            this.horasToolStripMenuItem2,
            this.horasToolStripMenuItem3,
            this.horasToolStripMenuItem4,
            this.horasToolStripMenuItem5});
            this.adiarToolStripMenuItem.Name = "adiarToolStripMenuItem";
            this.adiarToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.adiarToolStripMenuItem.Text = "Adiar";
            // 
            // minutosToolStripMenuItem
            // 
            this.minutosToolStripMenuItem.Name = "minutosToolStripMenuItem";
            this.minutosToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.minutosToolStripMenuItem.Text = "10 Minutos";
            // 
            // minutosToolStripMenuItem1
            // 
            this.minutosToolStripMenuItem1.Name = "minutosToolStripMenuItem1";
            this.minutosToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.minutosToolStripMenuItem1.Text = "20 Minutos";
            // 
            // minutosToolStripMenuItem2
            // 
            this.minutosToolStripMenuItem2.Name = "minutosToolStripMenuItem2";
            this.minutosToolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
            this.minutosToolStripMenuItem2.Text = "30 Minutos";
            // 
            // horaToolStripMenuItem
            // 
            this.horaToolStripMenuItem.Name = "horaToolStripMenuItem";
            this.horaToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.horaToolStripMenuItem.Text = "1 Hora";
            // 
            // horasToolStripMenuItem
            // 
            this.horasToolStripMenuItem.Name = "horasToolStripMenuItem";
            this.horasToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.horasToolStripMenuItem.Text = "2 Horas";
            // 
            // horasToolStripMenuItem1
            // 
            this.horasToolStripMenuItem1.Name = "horasToolStripMenuItem1";
            this.horasToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.horasToolStripMenuItem1.Text = "3 Horas";
            // 
            // horasToolStripMenuItem2
            // 
            this.horasToolStripMenuItem2.Name = "horasToolStripMenuItem2";
            this.horasToolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
            this.horasToolStripMenuItem2.Text = "4 Horas";
            // 
            // horasToolStripMenuItem3
            // 
            this.horasToolStripMenuItem3.Name = "horasToolStripMenuItem3";
            this.horasToolStripMenuItem3.Size = new System.Drawing.Size(133, 22);
            this.horasToolStripMenuItem3.Text = "5 Horas";
            // 
            // horasToolStripMenuItem4
            // 
            this.horasToolStripMenuItem4.Name = "horasToolStripMenuItem4";
            this.horasToolStripMenuItem4.Size = new System.Drawing.Size(133, 22);
            this.horasToolStripMenuItem4.Text = "6 Horas";
            // 
            // horasToolStripMenuItem5
            // 
            this.horasToolStripMenuItem5.Name = "horasToolStripMenuItem5";
            this.horasToolStripMenuItem5.Size = new System.Drawing.Size(133, 22);
            this.horasToolStripMenuItem5.Text = "12 Horas";
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
            this.gridEvents.Location = new System.Drawing.Point(0, 0);
            this.gridEvents.MultiSelect = false;
            this.gridEvents.Name = "gridEvents";
            this.gridEvents.ReadOnly = true;
            this.gridEvents.RowHeadersWidth = 25;
            this.gridEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEvents.Size = new System.Drawing.Size(752, 449);
            this.gridEvents.TabIndex = 1;
            this.gridEvents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GridEvents_KeyDown);
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
            // EventViwer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 449);
            this.Controls.Add(this.gridEvents);
            this.Name = "EventViwer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventViwer";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventViwer_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem descartarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minutosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minutosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem horaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem horasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem horasToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem horasToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem horasToolStripMenuItem5;
        private System.Windows.Forms.DataGridView gridEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlarmTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}