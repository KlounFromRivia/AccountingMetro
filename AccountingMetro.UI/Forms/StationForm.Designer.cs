namespace AccountingMetro.UI.Forms
{
    partial class StationForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStation = new System.Windows.Forms.TabPage();
            this.flpStation = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.tsslStatusStaion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabTrain = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiBack = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabStation.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(1077, 601);
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
            this.tabStation.Size = new System.Drawing.Size(1069, 572);
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
            this.flpStation.Size = new System.Drawing.Size(801, 542);
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
            this.panel1.Size = new System.Drawing.Size(260, 542);
            this.panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lstVetka);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(7, 205);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(9);
            this.groupBox2.Size = new System.Drawing.Size(246, 321);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ветки";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddVetka);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtNameVetka);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(9, 198);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(228, 114);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Добавление новой ветки";
            // 
            // btnAddVetka
            // 
            this.btnAddVetka.Enabled = false;
            this.btnAddVetka.Location = new System.Drawing.Point(8, 79);
            this.btnAddVetka.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddVetka.Name = "btnAddVetka";
            this.btnAddVetka.Size = new System.Drawing.Size(212, 28);
            this.btnAddVetka.TabIndex = 3;
            this.btnAddVetka.Text = "Добавить новую ветку";
            this.btnAddVetka.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Название";
            // 
            // txtNameVetka
            // 
            this.txtNameVetka.Location = new System.Drawing.Point(8, 47);
            this.txtNameVetka.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameVetka.Name = "txtNameVetka";
            this.txtNameVetka.Size = new System.Drawing.Size(211, 23);
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
            this.lstVetka.Size = new System.Drawing.Size(228, 165);
            this.lstVetka.TabIndex = 4;
            this.lstVetka.UseCompatibleStateImageBehavior = false;
            this.lstVetka.View = System.Windows.Forms.View.Details;
            // 
            // clmTitle
            // 
            this.clmTitle.Text = "Название";
            this.clmTitle.Width = 215;
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
            this.groupBox1.Text = "Станции";
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
            this.label4.Size = new System.Drawing.Size(140, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Поиск по названию";
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
            this.label1.Text = "Ветки";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatusStaion});
            this.statusStrip1.Location = new System.Drawing.Point(4, 546);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1061, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslStatusStaion
            // 
            this.tsslStatusStaion.Name = "tsslStatusStaion";
            this.tsslStatusStaion.Size = new System.Drawing.Size(183, 17);
            this.tsslStatusStaion.Text = "Кол-во открытых станций";
            // 
            // tabTrain
            // 
            this.tabTrain.Location = new System.Drawing.Point(4, 25);
            this.tabTrain.Margin = new System.Windows.Forms.Padding(4);
            this.tabTrain.Name = "tabTrain";
            this.tabTrain.Padding = new System.Windows.Forms.Padding(4);
            this.tabTrain.Size = new System.Drawing.Size(1069, 572);
            this.tabTrain.TabIndex = 1;
            this.tabTrain.Text = "Электропоезда";
            this.tabTrain.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1077, 24);
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
            // StationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 625);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(901, 643);
            this.Name = "StationForm";
            this.Text = "База данных";
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
        private System.Windows.Forms.ToolStripStatusLabel tsslStatusStaion;
        private System.Windows.Forms.TextBox txtSearchStation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiBack;
        private System.Windows.Forms.ColumnHeader clmTitle;
    }
}