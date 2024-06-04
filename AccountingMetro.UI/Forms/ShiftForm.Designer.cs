namespace AccountingMetro.UI.Forms
{
    partial class ShiftForm
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
            this.dgvShift = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiBack = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatusShift = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tsslCountSuccessShift = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtSearchFIO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ColumnEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlaceJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWorkPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNormShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOpenShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCloseShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatusShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPost = new System.Windows.Forms.ComboBox();
            this.tsmiExport = new System.Windows.Forms.ToolStripMenuItem();
            this.mntShift = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShift
            // 
            this.dgvShift.AllowUserToAddRows = false;
            this.dgvShift.AllowUserToDeleteRows = false;
            this.dgvShift.AllowUserToResizeColumns = false;
            this.dgvShift.AllowUserToResizeRows = false;
            this.dgvShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShift.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEmployee,
            this.ColumnPost,
            this.ColumnPlaceJob,
            this.ColumnWorkPhone,
            this.ColumnNormShift,
            this.ColumnOpenShift,
            this.ColumnCloseShift,
            this.ColumnStatusShift});
            this.dgvShift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShift.Location = new System.Drawing.Point(5, 208);
            this.dgvShift.Margin = new System.Windows.Forms.Padding(4);
            this.dgvShift.Name = "dgvShift";
            this.dgvShift.ReadOnly = true;
            this.dgvShift.Size = new System.Drawing.Size(1176, 365);
            this.dgvShift.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBack,
            this.tsmiExport});
            this.menuStrip1.Location = new System.Drawing.Point(5, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1176, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiBack
            // 
            this.tsmiBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiBack.Name = "tsmiBack";
            this.tsmiBack.Size = new System.Drawing.Size(59, 20);
            this.tsmiBack.Text = "Назад";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslCountSuccessShift});
            this.statusStrip1.Location = new System.Drawing.Point(5, 573);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1176, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 179);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Смены";
            // 
            // cmbStatusShift
            // 
            this.cmbStatusShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusShift.FormattingEnabled = true;
            this.cmbStatusShift.Location = new System.Drawing.Point(451, 83);
            this.cmbStatusShift.Name = "cmbStatusShift";
            this.cmbStatusShift.Size = new System.Drawing.Size(136, 24);
            this.cmbStatusShift.TabIndex = 1;
            this.cmbStatusShift.SelectedIndexChanged += new System.EventHandler(this.cmbPost_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mntShift);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbPost);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmbStation);
            this.panel2.Controls.Add(this.txtSearchFIO);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbStatusShift);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 179);
            this.panel2.TabIndex = 2;
            // 
            // tsslCountSuccessShift
            // 
            this.tsslCountSuccessShift.Name = "tsslCountSuccessShift";
            this.tsslCountSuccessShift.Size = new System.Drawing.Size(186, 17);
            this.tsslCountSuccessShift.Text = "Кол-во выполненных смен";
            // 
            // txtSearchFIO
            // 
            this.txtSearchFIO.Location = new System.Drawing.Point(188, 84);
            this.txtSearchFIO.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchFIO.Name = "txtSearchFIO";
            this.txtSearchFIO.Size = new System.Drawing.Size(241, 23);
            this.txtSearchFIO.TabIndex = 13;
            this.txtSearchFIO.TextChanged += new System.EventHandler(this.cmbPost_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Поиск по ФИО";
            // 
            // ColumnEmployee
            // 
            this.ColumnEmployee.DataPropertyName = "EmployeeFIO";
            this.ColumnEmployee.HeaderText = "Сотрудник";
            this.ColumnEmployee.Name = "ColumnEmployee";
            this.ColumnEmployee.ReadOnly = true;
            this.ColumnEmployee.Width = 250;
            // 
            // ColumnPost
            // 
            this.ColumnPost.DataPropertyName = "Post";
            this.ColumnPost.HeaderText = "Должность";
            this.ColumnPost.Name = "ColumnPost";
            this.ColumnPost.ReadOnly = true;
            this.ColumnPost.Width = 200;
            // 
            // ColumnPlaceJob
            // 
            this.ColumnPlaceJob.DataPropertyName = "PlaceJob";
            this.ColumnPlaceJob.HeaderText = "Место работы";
            this.ColumnPlaceJob.Name = "ColumnPlaceJob";
            this.ColumnPlaceJob.ReadOnly = true;
            this.ColumnPlaceJob.Width = 200;
            // 
            // ColumnWorkPhone
            // 
            this.ColumnWorkPhone.DataPropertyName = "WorkPhone";
            this.ColumnWorkPhone.HeaderText = "Рабочий телефон";
            this.ColumnWorkPhone.Name = "ColumnWorkPhone";
            this.ColumnWorkPhone.ReadOnly = true;
            this.ColumnWorkPhone.Width = 120;
            // 
            // ColumnNormShift
            // 
            this.ColumnNormShift.DataPropertyName = "NormaShift";
            this.ColumnNormShift.HeaderText = "Норма смены";
            this.ColumnNormShift.Name = "ColumnNormShift";
            this.ColumnNormShift.ReadOnly = true;
            // 
            // ColumnOpenShift
            // 
            this.ColumnOpenShift.DataPropertyName = "ShiftOpen";
            this.ColumnOpenShift.HeaderText = "Начало смены";
            this.ColumnOpenShift.Name = "ColumnOpenShift";
            this.ColumnOpenShift.ReadOnly = true;
            this.ColumnOpenShift.Width = 120;
            // 
            // ColumnCloseShift
            // 
            this.ColumnCloseShift.DataPropertyName = "ShiftClose";
            this.ColumnCloseShift.HeaderText = "Конец смены";
            this.ColumnCloseShift.Name = "ColumnCloseShift";
            this.ColumnCloseShift.ReadOnly = true;
            this.ColumnCloseShift.Width = 120;
            // 
            // ColumnStatusShift
            // 
            this.ColumnStatusShift.DataPropertyName = "StatusShift";
            this.ColumnStatusShift.HeaderText = "Статус смены";
            this.ColumnStatusShift.Name = "ColumnStatusShift";
            this.ColumnStatusShift.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Станции";
            // 
            // cmbStation
            // 
            this.cmbStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStation.FormattingEnabled = true;
            this.cmbStation.Location = new System.Drawing.Point(451, 28);
            this.cmbStation.Name = "cmbStation";
            this.cmbStation.Size = new System.Drawing.Size(190, 24);
            this.cmbStation.TabIndex = 15;
            this.cmbStation.SelectedIndexChanged += new System.EventHandler(this.cmbPost_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Должность";
            // 
            // cmbPost
            // 
            this.cmbPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPost.FormattingEnabled = true;
            this.cmbPost.Location = new System.Drawing.Point(188, 28);
            this.cmbPost.Name = "cmbPost";
            this.cmbPost.Size = new System.Drawing.Size(241, 24);
            this.cmbPost.TabIndex = 17;
            this.cmbPost.SelectedIndexChanged += new System.EventHandler(this.cmbPost_SelectedIndexChanged);
            // 
            // tsmiExport
            // 
            this.tsmiExport.Name = "tsmiExport";
            this.tsmiExport.Size = new System.Drawing.Size(128, 20);
            this.tsmiExport.Text = "Экспорт данных";
            this.tsmiExport.Click += new System.EventHandler(this.tsmiExport_Click);
            // 
            // mntShift
            // 
            this.mntShift.Location = new System.Drawing.Point(9, 9);
            this.mntShift.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.mntShift.Name = "mntShift";
            this.mntShift.TabIndex = 18;
            this.mntShift.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mntShift_DateChanged);
            // 
            // ShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 600);
            this.Controls.Add(this.dgvShift);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShiftForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Смены";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShift;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslCountSuccessShift;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStatusShift;
        private System.Windows.Forms.TextBox txtSearchFIO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlaceJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWorkPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNormShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOpenShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCloseShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatusShift;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStation;
        private System.Windows.Forms.ToolStripMenuItem tsmiExport;
        private System.Windows.Forms.MonthCalendar mntShift;
    }
}