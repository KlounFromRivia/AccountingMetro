namespace AccountingMetro.UI.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslFIO = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStaffDepart = new System.Windows.Forms.Button();
            this.btnBDOther = new System.Windows.Forms.Button();
            this.btnShift = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.picEmployee = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(767, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(59, 20);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslFIO});
            this.statusStrip1.Location = new System.Drawing.Point(0, 468);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(767, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslFIO
            // 
            this.tsslFIO.Name = "tsslFIO";
            this.tsslFIO.Size = new System.Drawing.Size(37, 17);
            this.tsslFIO.Text = "ФИО";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.picEmployee, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(767, 444);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStaffDepart);
            this.panel1.Controls.Add(this.btnBDOther);
            this.panel1.Controls.Add(this.btnShift);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(234, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 436);
            this.panel1.TabIndex = 0;
            // 
            // btnStaffDepart
            // 
            this.btnStaffDepart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStaffDepart.Location = new System.Drawing.Point(0, 171);
            this.btnStaffDepart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStaffDepart.Name = "btnStaffDepart";
            this.btnStaffDepart.Size = new System.Drawing.Size(298, 57);
            this.btnStaffDepart.TabIndex = 4;
            this.btnStaffDepart.Text = "Отдел кадров";
            this.btnStaffDepart.UseVisualStyleBackColor = true;
            this.btnStaffDepart.Click += new System.EventHandler(this.btnStaffDepart_Click);
            // 
            // btnBDOther
            // 
            this.btnBDOther.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBDOther.Location = new System.Drawing.Point(0, 114);
            this.btnBDOther.Margin = new System.Windows.Forms.Padding(4);
            this.btnBDOther.Name = "btnBDOther";
            this.btnBDOther.Size = new System.Drawing.Size(298, 57);
            this.btnBDOther.TabIndex = 2;
            this.btnBDOther.Text = "Метрополитен";
            this.btnBDOther.UseVisualStyleBackColor = true;
            this.btnBDOther.Click += new System.EventHandler(this.btnBDOther_Click);
            // 
            // btnShift
            // 
            this.btnShift.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShift.Location = new System.Drawing.Point(0, 57);
            this.btnShift.Margin = new System.Windows.Forms.Padding(4);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(298, 57);
            this.btnShift.TabIndex = 1;
            this.btnShift.Text = "Смены";
            this.btnShift.UseVisualStyleBackColor = true;
            this.btnShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmployee.Location = new System.Drawing.Point(0, 0);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(298, 57);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "Сотрудники";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // picEmployee
            // 
            this.picEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.picEmployee.Image = global::AccountingMetro.UI.Properties.Resources.employee;
            this.picEmployee.Location = new System.Drawing.Point(40, 30);
            this.picEmployee.Margin = new System.Windows.Forms.Padding(40, 30, 40, 0);
            this.picEmployee.Name = "picEmployee";
            this.picEmployee.Size = new System.Drawing.Size(150, 178);
            this.picEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmployee.TabIndex = 4;
            this.picEmployee.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 490);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отдел кадров";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslFIO;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStaffDepart;
        private System.Windows.Forms.Button btnBDOther;
        private System.Windows.Forms.Button btnShift;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.PictureBox picEmployee;
    }
}