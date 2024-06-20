namespace AccountingMetro.UI.Forms
{
    partial class StaffDepartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDepartForm));
            this.flpStaffDeparts = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStatusEmployee = new System.Windows.Forms.ComboBox();
            this.lblStation = new System.Windows.Forms.Label();
            this.cmbStation = new System.Windows.Forms.ComboBox();
            this.cmbVetka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tssmBack = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.grpList.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpStaffDeparts
            // 
            this.flpStaffDeparts.AutoScroll = true;
            this.flpStaffDeparts.BackColor = System.Drawing.Color.White;
            this.flpStaffDeparts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpStaffDeparts.Location = new System.Drawing.Point(275, 24);
            this.flpStaffDeparts.Margin = new System.Windows.Forms.Padding(5);
            this.flpStaffDeparts.Name = "flpStaffDeparts";
            this.flpStaffDeparts.Size = new System.Drawing.Size(486, 527);
            this.flpStaffDeparts.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.grpList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.panel1.Size = new System.Drawing.Size(275, 527);
            this.panel1.TabIndex = 5;
            // 
            // grpList
            // 
            this.grpList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpList.Controls.Add(this.groupBox1);
            this.grpList.Controls.Add(this.btnAddStaff);
            this.grpList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpList.Location = new System.Drawing.Point(9, 7);
            this.grpList.Margin = new System.Windows.Forms.Padding(5);
            this.grpList.Name = "grpList";
            this.grpList.Padding = new System.Windows.Forms.Padding(5);
            this.grpList.Size = new System.Drawing.Size(257, 428);
            this.grpList.TabIndex = 2;
            this.grpList.TabStop = false;
            this.grpList.Text = "Отображать в списке";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbStatusEmployee);
            this.groupBox1.Controls.Add(this.lblStation);
            this.groupBox1.Controls.Add(this.cmbStation);
            this.groupBox1.Controls.Add(this.cmbVetka);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(9);
            this.groupBox1.Size = new System.Drawing.Size(232, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(44, 290);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(145, 28);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Сбросить";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "По ФИО";
            // 
            // txtFam
            // 
            this.txtFam.Location = new System.Drawing.Point(9, 55);
            this.txtFam.Margin = new System.Windows.Forms.Padding(5);
            this.txtFam.Name = "txtFam";
            this.txtFam.Size = new System.Drawing.Size(214, 23);
            this.txtFam.TabIndex = 11;
            this.txtFam.TextChanged += new System.EventHandler(this.cmbVetka_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Статус сотрудника";
            // 
            // cmbStatusEmployee
            // 
            this.cmbStatusEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusEmployee.FormattingEnabled = true;
            this.cmbStatusEmployee.Location = new System.Drawing.Point(9, 226);
            this.cmbStatusEmployee.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cmbStatusEmployee.Name = "cmbStatusEmployee";
            this.cmbStatusEmployee.Size = new System.Drawing.Size(214, 24);
            this.cmbStatusEmployee.TabIndex = 16;
            this.cmbStatusEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbVetka_SelectedIndexChanged);
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(16, 146);
            this.lblStation.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(85, 16);
            this.lblStation.TabIndex = 8;
            this.lblStation.Text = "По станции";
            // 
            // cmbStation
            // 
            this.cmbStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStation.FormattingEnabled = true;
            this.cmbStation.Location = new System.Drawing.Point(9, 168);
            this.cmbStation.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cmbStation.Name = "cmbStation";
            this.cmbStation.Size = new System.Drawing.Size(214, 24);
            this.cmbStation.TabIndex = 9;
            this.cmbStation.SelectedIndexChanged += new System.EventHandler(this.cmbVetka_SelectedIndexChanged);
            // 
            // cmbVetka
            // 
            this.cmbVetka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVetka.FormattingEnabled = true;
            this.cmbVetka.Location = new System.Drawing.Point(9, 115);
            this.cmbVetka.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cmbVetka.Name = "cmbVetka";
            this.cmbVetka.Size = new System.Drawing.Size(214, 24);
            this.cmbVetka.TabIndex = 7;
            this.cmbVetka.SelectedIndexChanged += new System.EventHandler(this.cmbVetka_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "По ветке";
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddStaff.Location = new System.Drawing.Point(5, 382);
            this.btnAddStaff.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(247, 41);
            this.btnAddStaff.TabIndex = 14;
            this.btnAddStaff.Text = "Добавить нового сотрудника отдела кадров";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssmBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(761, 24);
            this.menuStrip1.TabIndex = 7;
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
            // StaffDepartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 551);
            this.Controls.Add(this.flpStaffDeparts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(777, 590);
            this.Name = "StaffDepartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Сотрудники отдела кадров";
            this.panel1.ResumeLayout(false);
            this.grpList.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpStaffDeparts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStatusEmployee;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.ComboBox cmbStation;
        private System.Windows.Forms.ComboBox cmbVetka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tssmBack;
        private System.Windows.Forms.Button btnReset;
    }
}