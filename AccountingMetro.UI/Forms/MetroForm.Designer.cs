namespace AccountingMetro.UI.Forms
{
    partial class MetroForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetroForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStation = new System.Windows.Forms.TabPage();
            this.flpStation = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteVETKA = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddVetka = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameVetka = new System.Windows.Forms.TextBox();
            this.lstVetka = new System.Windows.Forms.ListView();
            this.clmTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchStation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbStatStation = new System.Windows.Forms.ComboBox();
            this.btnAddStation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVetka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslStatusStation = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabTrain = new System.Windows.Forms.TabPage();
            this.flpTrain = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnAddTrain = new System.Windows.Forms.Button();
            this.txtSearchTrain = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbStatusTrain = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbVetkaTrain = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.tsslCountTrain = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiBack = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabStation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabTrain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabStation);
            this.tabControl1.Controls.Add(this.tabTrain);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1074, 617);
            this.tabControl1.TabIndex = 0;
            // 
            // tabStation
            // 
            this.tabStation.Controls.Add(this.flpStation);
            this.tabStation.Controls.Add(this.panel1);
            this.tabStation.Controls.Add(this.statusStrip1);
            this.tabStation.Location = new System.Drawing.Point(4, 25);
            this.tabStation.Margin = new System.Windows.Forms.Padding(4);
            this.tabStation.Name = "tabStation";
            this.tabStation.Padding = new System.Windows.Forms.Padding(4);
            this.tabStation.Size = new System.Drawing.Size(1066, 588);
            this.tabStation.TabIndex = 0;
            this.tabStation.Text = "Станции";
            this.tabStation.UseVisualStyleBackColor = true;
            // 
            // flpStation
            // 
            this.flpStation.AutoScroll = true;
            this.flpStation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpStation.Location = new System.Drawing.Point(264, 4);
            this.flpStation.Margin = new System.Windows.Forms.Padding(4);
            this.flpStation.Name = "flpStation";
            this.flpStation.Size = new System.Drawing.Size(798, 558);
            this.flpStation.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Size = new System.Drawing.Size(260, 558);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteVETKA);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lstVetka);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(7, 205);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(9);
            this.groupBox2.Size = new System.Drawing.Size(246, 343);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ветки";
            // 
            // btnDeleteVETKA
            // 
            this.btnDeleteVETKA.Enabled = false;
            this.btnDeleteVETKA.Location = new System.Drawing.Point(9, 190);
            this.btnDeleteVETKA.Name = "btnDeleteVETKA";
            this.btnDeleteVETKA.Size = new System.Drawing.Size(228, 25);
            this.btnDeleteVETKA.TabIndex = 6;
            this.btnDeleteVETKA.Text = "Удалить выбранную ветку";
            this.btnDeleteVETKA.UseVisualStyleBackColor = true;
            this.btnDeleteVETKA.Click += new System.EventHandler(this.btnDeleteVETKA_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddVetka);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtNameVetka);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(9, 222);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(228, 112);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Добавление новой ветки";
            // 
            // btnAddVetka
            // 
            this.btnAddVetka.Enabled = false;
            this.btnAddVetka.Location = new System.Drawing.Point(8, 71);
            this.btnAddVetka.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddVetka.Name = "btnAddVetka";
            this.btnAddVetka.Size = new System.Drawing.Size(212, 28);
            this.btnAddVetka.TabIndex = 3;
            this.btnAddVetka.Text = "Добавить новую ветку";
            this.btnAddVetka.UseVisualStyleBackColor = true;
            this.btnAddVetka.Click += new System.EventHandler(this.btnAddVetka_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Название";
            // 
            // txtNameVetka
            // 
            this.txtNameVetka.Location = new System.Drawing.Point(5, 40);
            this.txtNameVetka.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameVetka.Name = "txtNameVetka";
            this.txtNameVetka.Size = new System.Drawing.Size(215, 23);
            this.txtNameVetka.TabIndex = 5;
            this.txtNameVetka.TextChanged += new System.EventHandler(this.txtNameVetka_TextChanged);
            // 
            // lstVetka
            // 
            this.lstVetka.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmTitle});
            this.lstVetka.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstVetka.HideSelection = false;
            this.lstVetka.Location = new System.Drawing.Point(9, 25);
            this.lstVetka.Margin = new System.Windows.Forms.Padding(4);
            this.lstVetka.Name = "lstVetka";
            this.lstVetka.Size = new System.Drawing.Size(228, 158);
            this.lstVetka.TabIndex = 4;
            this.lstVetka.UseCompatibleStateImageBehavior = false;
            this.lstVetka.View = System.Windows.Forms.View.Details;
            this.lstVetka.SelectedIndexChanged += new System.EventHandler(this.lstVetka_SelectedIndexChanged);
            // 
            // clmTitle
            // 
            this.clmTitle.Text = "Название";
            this.clmTitle.Width = 201;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchStation);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbStatStation);
            this.groupBox1.Controls.Add(this.btnAddStation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbVetka);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Size = new System.Drawing.Size(246, 199);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Станция";
            // 
            // txtSearchStation
            // 
            this.txtSearchStation.Location = new System.Drawing.Point(14, 41);
            this.txtSearchStation.Name = "txtSearchStation";
            this.txtSearchStation.Size = new System.Drawing.Size(220, 23);
            this.txtSearchStation.TabIndex = 5;
            this.txtSearchStation.TextChanged += new System.EventHandler(this.cmbStatStation_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Название";
            // 
            // cmbStatStation
            // 
            this.cmbStatStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatStation.FormattingEnabled = true;
            this.cmbStatStation.Location = new System.Drawing.Point(15, 87);
            this.cmbStatStation.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStatStation.Name = "cmbStatStation";
            this.cmbStatStation.Size = new System.Drawing.Size(220, 24);
            this.cmbStatStation.TabIndex = 3;
            this.cmbStatStation.SelectedIndexChanged += new System.EventHandler(this.cmbStatStation_SelectedIndexChanged);
            // 
            // btnAddStation
            // 
            this.btnAddStation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddStation.Location = new System.Drawing.Point(7, 165);
            this.btnAddStation.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddStation.Name = "btnAddStation";
            this.btnAddStation.Size = new System.Drawing.Size(232, 28);
            this.btnAddStation.TabIndex = 2;
            this.btnAddStation.Text = "Добавить новую станцию";
            this.btnAddStation.UseVisualStyleBackColor = true;
            this.btnAddStation.Click += new System.EventHandler(this.btnAddStation_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Состояние станции";
            // 
            // cmbVetka
            // 
            this.cmbVetka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVetka.FormattingEnabled = true;
            this.cmbVetka.Location = new System.Drawing.Point(65, 118);
            this.cmbVetka.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVetka.Name = "cmbVetka";
            this.cmbVetka.Size = new System.Drawing.Size(169, 24);
            this.cmbVetka.TabIndex = 1;
            this.cmbVetka.SelectedIndexChanged += new System.EventHandler(this.cmbStatStation_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ветка";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatusStation});
            this.statusStrip1.Location = new System.Drawing.Point(4, 562);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1058, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslStatusStation
            // 
            this.tsslStatusStation.Name = "tsslStatusStation";
            this.tsslStatusStation.Size = new System.Drawing.Size(183, 17);
            this.tsslStatusStation.Text = "Кол-во открытых станций";
            // 
            // tabTrain
            // 
            this.tabTrain.Controls.Add(this.flpTrain);
            this.tabTrain.Controls.Add(this.panel2);
            this.tabTrain.Controls.Add(this.statusStrip2);
            this.tabTrain.Location = new System.Drawing.Point(4, 25);
            this.tabTrain.Margin = new System.Windows.Forms.Padding(4);
            this.tabTrain.Name = "tabTrain";
            this.tabTrain.Padding = new System.Windows.Forms.Padding(4);
            this.tabTrain.Size = new System.Drawing.Size(1066, 588);
            this.tabTrain.TabIndex = 1;
            this.tabTrain.Text = "Электропоезда";
            this.tabTrain.UseVisualStyleBackColor = true;
            // 
            // flpTrain
            // 
            this.flpTrain.AutoScroll = true;
            this.flpTrain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTrain.Location = new System.Drawing.Point(264, 4);
            this.flpTrain.Margin = new System.Windows.Forms.Padding(4);
            this.flpTrain.Name = "flpTrain";
            this.flpTrain.Size = new System.Drawing.Size(798, 558);
            this.flpTrain.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel2.Size = new System.Drawing.Size(260, 558);
            this.panel2.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnAddTrain);
            this.groupBox6.Controls.Add(this.txtSearchTrain);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.cmbStatusTrain);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.cmbVetkaTrain);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(7, 6);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox6.Size = new System.Drawing.Size(246, 210);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Электропоезд";
            // 
            // btnAddTrain
            // 
            this.btnAddTrain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddTrain.Location = new System.Drawing.Point(7, 176);
            this.btnAddTrain.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTrain.Name = "btnAddTrain";
            this.btnAddTrain.Size = new System.Drawing.Size(232, 28);
            this.btnAddTrain.TabIndex = 2;
            this.btnAddTrain.Text = "Добавить новый поезд";
            this.btnAddTrain.UseVisualStyleBackColor = true;
            this.btnAddTrain.Click += new System.EventHandler(this.btnAddTrain_Click);
            // 
            // txtSearchTrain
            // 
            this.txtSearchTrain.Location = new System.Drawing.Point(14, 41);
            this.txtSearchTrain.Name = "txtSearchTrain";
            this.txtSearchTrain.Size = new System.Drawing.Size(220, 23);
            this.txtSearchTrain.TabIndex = 5;
            this.txtSearchTrain.TextChanged += new System.EventHandler(this.cmbStatusTrain_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Номер";
            // 
            // cmbStatusTrain
            // 
            this.cmbStatusTrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusTrain.FormattingEnabled = true;
            this.cmbStatusTrain.Location = new System.Drawing.Point(15, 87);
            this.cmbStatusTrain.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStatusTrain.Name = "cmbStatusTrain";
            this.cmbStatusTrain.Size = new System.Drawing.Size(220, 24);
            this.cmbStatusTrain.TabIndex = 3;
            this.cmbStatusTrain.SelectedIndexChanged += new System.EventHandler(this.cmbStatusTrain_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Состояние поезда";
            // 
            // cmbVetkaTrain
            // 
            this.cmbVetkaTrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVetkaTrain.FormattingEnabled = true;
            this.cmbVetkaTrain.Location = new System.Drawing.Point(65, 118);
            this.cmbVetkaTrain.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVetkaTrain.Name = "cmbVetkaTrain";
            this.cmbVetkaTrain.Size = new System.Drawing.Size(169, 24);
            this.cmbVetkaTrain.TabIndex = 1;
            this.cmbVetkaTrain.SelectedIndexChanged += new System.EventHandler(this.cmbStatusTrain_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 121);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ветка";
            // 
            // statusStrip2
            // 
            this.statusStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip2.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslCountTrain});
            this.statusStrip2.Location = new System.Drawing.Point(4, 562);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1058, 22);
            this.statusStrip2.TabIndex = 3;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // tsslCountTrain
            // 
            this.tsslCountTrain.Name = "tsslCountTrain";
            this.tsslCountTrain.Size = new System.Drawing.Size(204, 17);
            this.tsslCountTrain.Text = "Кол-во работающих поездов";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1074, 24);
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
            // MetroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 641);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(700, 680);
            this.Name = "MetroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Метрополитен";
            this.tabControl1.ResumeLayout(false);
            this.tabStation.ResumeLayout(false);
            this.tabStation.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabTrain.ResumeLayout(false);
            this.tabTrain.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStation;
        private System.Windows.Forms.TabPage tabTrain;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbVetka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddStation;
        private System.Windows.Forms.ComboBox cmbStatStation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddVetka;
        private System.Windows.Forms.FlowLayoutPanel flpStation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lstVetka;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameVetka;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatusStation;
        private System.Windows.Forms.TextBox txtSearchStation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiBack;
        private System.Windows.Forms.ColumnHeader clmTitle;
        private System.Windows.Forms.Button btnDeleteVETKA;
        private System.Windows.Forms.FlowLayoutPanel flpTrain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtSearchTrain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbStatusTrain;
        private System.Windows.Forms.Button btnAddTrain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbVetkaTrain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel tsslCountTrain;
    }
}