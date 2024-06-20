namespace AccountingMetro.UI.Forms
{
    partial class EmployeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatusEmployee = new System.Windows.Forms.ComboBox();
            this.cmbPost = new System.Windows.Forms.ComboBox();
            this.lblStation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStation = new System.Windows.Forms.ComboBox();
            this.cmbVetka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslCountEmployee = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslStatusEmployee = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslCountOnStation = new System.Windows.Forms.ToolStripStatusLabel();
            this.flpEmployees = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tssmBack = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.grpList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.grpList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Size = new System.Drawing.Size(257, 534);
            this.panel1.TabIndex = 0;
            // 
            // grpList
            // 
            this.grpList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpList.Controls.Add(this.groupBox1);
            this.grpList.Controls.Add(this.btnAddEmployee);
            this.grpList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpList.Location = new System.Drawing.Point(7, 6);
            this.grpList.Margin = new System.Windows.Forms.Padding(4);
            this.grpList.Name = "grpList";
            this.grpList.Padding = new System.Windows.Forms.Padding(4);
            this.grpList.Size = new System.Drawing.Size(243, 347);
            this.grpList.TabIndex = 2;
            this.grpList.TabStop = false;
            this.grpList.Text = "Отображать в списке";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbStatusEmployee);
            this.groupBox1.Controls.Add(this.cmbPost);
            this.groupBox1.Controls.Add(this.lblStation);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbStation);
            this.groupBox1.Controls.Add(this.cmbVetka);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7);
            this.groupBox1.Size = new System.Drawing.Size(225, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "По ФИО";
            // 
            // txtFam
            // 
            this.txtFam.Location = new System.Drawing.Point(7, 45);
            this.txtFam.Margin = new System.Windows.Forms.Padding(4);
            this.txtFam.Name = "txtFam";
            this.txtFam.Size = new System.Drawing.Size(209, 23);
            this.txtFam.TabIndex = 11;
            this.txtFam.TextChanged += new System.EventHandler(this.cmbPost_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Статус сотрудника";
            // 
            // cmbStatusEmployee
            // 
            this.cmbStatusEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusEmployee.FormattingEnabled = true;
            this.cmbStatusEmployee.Location = new System.Drawing.Point(7, 231);
            this.cmbStatusEmployee.Margin = new System.Windows.Forms.Padding(5);
            this.cmbStatusEmployee.Name = "cmbStatusEmployee";
            this.cmbStatusEmployee.Size = new System.Drawing.Size(209, 24);
            this.cmbStatusEmployee.TabIndex = 16;
            this.cmbStatusEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbPost_SelectedIndexChanged);
            // 
            // cmbPost
            // 
            this.cmbPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPost.DropDownWidth = 250;
            this.cmbPost.FormattingEnabled = true;
            this.cmbPost.Location = new System.Drawing.Point(7, 90);
            this.cmbPost.Margin = new System.Windows.Forms.Padding(5);
            this.cmbPost.Name = "cmbPost";
            this.cmbPost.Size = new System.Drawing.Size(209, 24);
            this.cmbPost.TabIndex = 13;
            this.cmbPost.SelectedIndexChanged += new System.EventHandler(this.cmbPost_SelectedIndexChanged);
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(12, 166);
            this.lblStation.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(85, 16);
            this.lblStation.TabIndex = 8;
            this.lblStation.Text = "По станции";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "По должности";
            // 
            // cmbStation
            // 
            this.cmbStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStation.FormattingEnabled = true;
            this.cmbStation.Location = new System.Drawing.Point(7, 184);
            this.cmbStation.Margin = new System.Windows.Forms.Padding(5);
            this.cmbStation.Name = "cmbStation";
            this.cmbStation.Size = new System.Drawing.Size(209, 24);
            this.cmbStation.TabIndex = 9;
            this.cmbStation.SelectedIndexChanged += new System.EventHandler(this.cmbPost_SelectedIndexChanged);
            // 
            // cmbVetka
            // 
            this.cmbVetka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVetka.FormattingEnabled = true;
            this.cmbVetka.Location = new System.Drawing.Point(7, 137);
            this.cmbVetka.Margin = new System.Windows.Forms.Padding(5);
            this.cmbVetka.Name = "cmbVetka";
            this.cmbVetka.Size = new System.Drawing.Size(209, 24);
            this.cmbVetka.TabIndex = 7;
            this.cmbVetka.SelectedIndexChanged += new System.EventHandler(this.cmbPost_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "По ветке";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddEmployee.Location = new System.Drawing.Point(4, 310);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(235, 33);
            this.btnAddEmployee.TabIndex = 14;
            this.btnAddEmployee.Text = "Добавить нового сотрудника";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslCountEmployee,
            this.tsslStatusEmployee,
            this.tsslCountOnStation});
            this.statusStrip1.Location = new System.Drawing.Point(0, 558);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(961, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslCountEmployee
            // 
            this.tsslCountEmployee.Name = "tsslCountEmployee";
            this.tsslCountEmployee.Size = new System.Drawing.Size(146, 17);
            this.tsslCountEmployee.Text = "Кол-во сотрудников";
            // 
            // tsslStatusEmployee
            // 
            this.tsslStatusEmployee.Name = "tsslStatusEmployee";
            this.tsslStatusEmployee.Size = new System.Drawing.Size(236, 17);
            this.tsslStatusEmployee.Text = "Кол-во работающих сотрудников";
            // 
            // tsslCountOnStation
            // 
            this.tsslCountOnStation.Name = "tsslCountOnStation";
            this.tsslCountOnStation.Size = new System.Drawing.Size(136, 17);
            this.tsslCountOnStation.Text = "Кол-во на станции";
            this.tsslCountOnStation.Visible = false;
            // 
            // flpEmployees
            // 
            this.flpEmployees.AutoScroll = true;
            this.flpEmployees.BackColor = System.Drawing.Color.White;
            this.flpEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpEmployees.Location = new System.Drawing.Point(257, 24);
            this.flpEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.flpEmployees.Name = "flpEmployees";
            this.flpEmployees.Size = new System.Drawing.Size(704, 534);
            this.flpEmployees.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssmBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(961, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tssmBack
            // 
            this.tssmBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tssmBack.Name = "tssmBack";
            this.tssmBack.Size = new System.Drawing.Size(59, 20);
            this.tssmBack.Text = "Назад";
            this.tssmBack.Click += new System.EventHandler(this.tssmBack_Click);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 580);
            this.Controls.Add(this.flpEmployees);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(522, 619);
            this.Name = "EmployeesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Просмотр (редактирование) данных сотрудника";
            this.panel1.ResumeLayout(false);
            this.grpList.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txtFam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbStation;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.ComboBox cmbVetka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel tsslCountEmployee;
        private System.Windows.Forms.ToolStripStatusLabel tsslCountOnStation;
        private System.Windows.Forms.FlowLayoutPanel flpEmployees;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tssmBack;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.ComboBox cmbStatusEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatusEmployee;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}