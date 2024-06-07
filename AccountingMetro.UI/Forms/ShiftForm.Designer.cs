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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShiftForm));
            this.dgvShift = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlaceJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWorkPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNormShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOpenShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCloseShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatusShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiBack = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExport = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslCountSuccessShift = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnStartShift = new System.Windows.Forms.Button();
            this.grpPoisk = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDayShift = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEndShift = new System.Windows.Forms.DateTimePicker();
            this.dtpStartShift = new System.Windows.Forms.DateTimePicker();
            this.txtSearchFIO = new System.Windows.Forms.TextBox();
            this.lblFio = new System.Windows.Forms.Label();
            this.cmbPost = new System.Windows.Forms.ComboBox();
            this.lblShift = new System.Windows.Forms.Label();
            this.lblStation = new System.Windows.Forms.Label();
            this.cmbStatusShift = new System.Windows.Forms.ComboBox();
            this.lblPost = new System.Windows.Forms.Label();
            this.cmbStation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grpPoisk.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.ColumnId,
            this.ColumnEmployeeId,
            this.ColumnEmployee,
            this.ColumnPost,
            this.ColumnPlaceJob,
            this.ColumnWorkPhone,
            this.ColumnNormShift,
            this.ColumnOpenShift,
            this.ColumnCloseShift,
            this.ColumnStatusShift});
            this.dgvShift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShift.Location = new System.Drawing.Point(5, 189);
            this.dgvShift.Margin = new System.Windows.Forms.Padding(4);
            this.dgvShift.MultiSelect = false;
            this.dgvShift.Name = "dgvShift";
            this.dgvShift.ReadOnly = true;
            this.dgvShift.Size = new System.Drawing.Size(1274, 445);
            this.dgvShift.TabIndex = 0;
            this.dgvShift.SelectionChanged += new System.EventHandler(this.dgvShift_SelectionChanged);
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "Id";
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnEmployeeId
            // 
            this.ColumnEmployeeId.DataPropertyName = "EmployeeId";
            this.ColumnEmployeeId.HeaderText = "EmployeeId";
            this.ColumnEmployeeId.Name = "ColumnEmployeeId";
            this.ColumnEmployeeId.ReadOnly = true;
            this.ColumnEmployeeId.Visible = false;
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
            this.ColumnPlaceJob.Width = 250;
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
            this.ColumnNormShift.HeaderText = "Норма смены ч.";
            this.ColumnNormShift.Name = "ColumnNormShift";
            this.ColumnNormShift.ReadOnly = true;
            // 
            // ColumnOpenShift
            // 
            this.ColumnOpenShift.DataPropertyName = "ShiftOpen";
            this.ColumnOpenShift.HeaderText = "Начало смены";
            this.ColumnOpenShift.Name = "ColumnOpenShift";
            this.ColumnOpenShift.ReadOnly = true;
            this.ColumnOpenShift.Width = 140;
            // 
            // ColumnCloseShift
            // 
            this.ColumnCloseShift.DataPropertyName = "ShiftClose";
            this.ColumnCloseShift.HeaderText = "Конец смены";
            this.ColumnCloseShift.Name = "ColumnCloseShift";
            this.ColumnCloseShift.ReadOnly = true;
            this.ColumnCloseShift.Width = 140;
            // 
            // ColumnStatusShift
            // 
            this.ColumnStatusShift.DataPropertyName = "StatusShift";
            this.ColumnStatusShift.HeaderText = "Статус смены";
            this.ColumnStatusShift.Name = "ColumnStatusShift";
            this.ColumnStatusShift.ReadOnly = true;
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
            this.menuStrip1.Size = new System.Drawing.Size(1274, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiBack
            // 
            this.tsmiBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiBack.Name = "tsmiBack";
            this.tsmiBack.Size = new System.Drawing.Size(59, 20);
            this.tsmiBack.Text = "Назад";
            this.tsmiBack.Click += new System.EventHandler(this.tsmiBack_Click);
            // 
            // tsmiExport
            // 
            this.tsmiExport.Name = "tsmiExport";
            this.tsmiExport.Size = new System.Drawing.Size(128, 20);
            this.tsmiExport.Text = "Экспорт данных";
            this.tsmiExport.Click += new System.EventHandler(this.tsmiExport_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslCountSuccessShift});
            this.statusStrip1.Location = new System.Drawing.Point(5, 634);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1274, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslCountSuccessShift
            // 
            this.tsslCountSuccessShift.Name = "tsslCountSuccessShift";
            this.tsslCountSuccessShift.Size = new System.Drawing.Size(186, 17);
            this.tsslCountSuccessShift.Text = "Кол-во выполненных смен";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1274, 160);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.grpPoisk);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(1008, 160);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnStartShift);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(763, 10);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(173, 140);
            this.panel3.TabIndex = 22;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.Location = new System.Drawing.Point(10, 41);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(153, 31);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Удалить смену";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnStartShift
            // 
            this.btnStartShift.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStartShift.Location = new System.Drawing.Point(10, 10);
            this.btnStartShift.Name = "btnStartShift";
            this.btnStartShift.Size = new System.Drawing.Size(153, 31);
            this.btnStartShift.TabIndex = 3;
            this.btnStartShift.Text = "Добавить смену";
            this.btnStartShift.UseVisualStyleBackColor = true;
            this.btnStartShift.Visible = false;
            this.btnStartShift.Click += new System.EventHandler(this.btnStartShift_Click);
            // 
            // grpPoisk
            // 
            this.grpPoisk.Controls.Add(this.groupBox1);
            this.grpPoisk.Controls.Add(this.txtSearchFIO);
            this.grpPoisk.Controls.Add(this.lblFio);
            this.grpPoisk.Controls.Add(this.cmbPost);
            this.grpPoisk.Controls.Add(this.lblShift);
            this.grpPoisk.Controls.Add(this.lblStation);
            this.grpPoisk.Controls.Add(this.cmbStatusShift);
            this.grpPoisk.Controls.Add(this.lblPost);
            this.grpPoisk.Controls.Add(this.cmbStation);
            this.grpPoisk.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpPoisk.Location = new System.Drawing.Point(10, 10);
            this.grpPoisk.Name = "grpPoisk";
            this.grpPoisk.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.grpPoisk.Size = new System.Drawing.Size(753, 140);
            this.grpPoisk.TabIndex = 21;
            this.grpPoisk.TabStop = false;
            this.grpPoisk.Text = "Смены ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDayShift);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpEndShift);
            this.groupBox1.Controls.Add(this.dtpStartShift);
            this.groupBox1.Location = new System.Drawing.Point(13, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 63);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дата смены";
            // 
            // lblDayShift
            // 
            this.lblDayShift.AutoSize = true;
            this.lblDayShift.Location = new System.Drawing.Point(8, 30);
            this.lblDayShift.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDayShift.Name = "lblDayShift";
            this.lblDayShift.Size = new System.Drawing.Size(24, 16);
            this.lblDayShift.TabIndex = 20;
            this.lblDayShift.Text = "От";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "До";
            // 
            // dtpEndShift
            // 
            this.dtpEndShift.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndShift.Location = new System.Drawing.Point(184, 25);
            this.dtpEndShift.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dtpEndShift.Name = "dtpEndShift";
            this.dtpEndShift.Size = new System.Drawing.Size(103, 23);
            this.dtpEndShift.TabIndex = 21;
            this.dtpEndShift.Value = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dtpEndShift.ValueChanged += new System.EventHandler(this.dtpShift_ValueChanged);
            // 
            // dtpStartShift
            // 
            this.dtpStartShift.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartShift.Location = new System.Drawing.Point(40, 25);
            this.dtpStartShift.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.dtpStartShift.Name = "dtpStartShift";
            this.dtpStartShift.Size = new System.Drawing.Size(103, 23);
            this.dtpStartShift.TabIndex = 19;
            this.dtpStartShift.Value = new System.DateTime(2023, 6, 7, 0, 0, 0, 0);
            this.dtpStartShift.ValueChanged += new System.EventHandler(this.dtpShift_ValueChanged);
            // 
            // txtSearchFIO
            // 
            this.txtSearchFIO.Location = new System.Drawing.Point(321, 41);
            this.txtSearchFIO.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchFIO.Name = "txtSearchFIO";
            this.txtSearchFIO.Size = new System.Drawing.Size(225, 23);
            this.txtSearchFIO.TabIndex = 13;
            this.txtSearchFIO.TextChanged += new System.EventHandler(this.cmbPost_SelectedIndexChanged);
            // 
            // lblFio
            // 
            this.lblFio.AutoSize = true;
            this.lblFio.Location = new System.Drawing.Point(330, 21);
            this.lblFio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFio.Name = "lblFio";
            this.lblFio.Size = new System.Drawing.Size(37, 16);
            this.lblFio.TabIndex = 12;
            this.lblFio.Text = "ФИО";
            // 
            // cmbPost
            // 
            this.cmbPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPost.FormattingEnabled = true;
            this.cmbPost.Location = new System.Drawing.Point(321, 98);
            this.cmbPost.Name = "cmbPost";
            this.cmbPost.Size = new System.Drawing.Size(225, 24);
            this.cmbPost.TabIndex = 17;
            this.cmbPost.SelectedIndexChanged += new System.EventHandler(this.cmbPost_SelectedIndexChanged);
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Location = new System.Drawing.Point(21, 101);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(49, 16);
            this.lblShift.TabIndex = 0;
            this.lblShift.Text = "Смена";
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(564, 21);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(64, 16);
            this.lblStation.TabIndex = 14;
            this.lblStation.Text = "Станция";
            // 
            // cmbStatusShift
            // 
            this.cmbStatusShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusShift.FormattingEnabled = true;
            this.cmbStatusShift.Location = new System.Drawing.Point(76, 98);
            this.cmbStatusShift.Name = "cmbStatusShift";
            this.cmbStatusShift.Size = new System.Drawing.Size(113, 24);
            this.cmbStatusShift.TabIndex = 1;
            this.cmbStatusShift.SelectedIndexChanged += new System.EventHandler(this.cmbPost_SelectedIndexChanged);
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Location = new System.Drawing.Point(330, 79);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(82, 16);
            this.lblPost.TabIndex = 16;
            this.lblPost.Text = "Должность";
            // 
            // cmbStation
            // 
            this.cmbStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStation.FormattingEnabled = true;
            this.cmbStation.Location = new System.Drawing.Point(557, 40);
            this.cmbStation.Name = "cmbStation";
            this.cmbStation.Size = new System.Drawing.Size(190, 24);
            this.cmbStation.TabIndex = 15;
            this.cmbStation.SelectedIndexChanged += new System.EventHandler(this.cmbPost_SelectedIndexChanged);
            // 
            // ShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.dgvShift);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1500, 1000);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "ShiftForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Смены сотрудников";
            this.Load += new System.EventHandler(this.ShiftForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShift)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.grpPoisk.ResumeLayout(false);
            this.grpPoisk.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.ComboBox cmbStatusShift;
        private System.Windows.Forms.TextBox txtSearchFIO;
        private System.Windows.Forms.Label lblFio;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.ComboBox cmbPost;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.ComboBox cmbStation;
        private System.Windows.Forms.ToolStripMenuItem tsmiExport;
        private System.Windows.Forms.Button btnStartShift;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DateTimePicker dtpStartShift;
        private System.Windows.Forms.GroupBox grpPoisk;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlaceJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWorkPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNormShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOpenShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCloseShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatusShift;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDayShift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEndShift;
    }
}