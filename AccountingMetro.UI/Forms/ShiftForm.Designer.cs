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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsmiBack = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ColumnEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWorkPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNormShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOpenShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCloseShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatusShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnEmployee,
            this.ColumnPost,
            this.ColumnWorkPhone,
            this.ColumnNormShift,
            this.ColumnOpenShift,
            this.ColumnCloseShift,
            this.ColumnStatusShift});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 147);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1084, 411);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.statusStrip1.Location = new System.Drawing.Point(0, 558);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1084, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsmiBack
            // 
            this.tsmiBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiBack.Name = "tsmiBack";
            this.tsmiBack.Size = new System.Drawing.Size(51, 20);
            this.tsmiBack.Text = "Назад";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 123);
            this.panel1.TabIndex = 3;
            // 
            // ColumnEmployee
            // 
            this.ColumnEmployee.HeaderText = "Сотрудник";
            this.ColumnEmployee.Name = "ColumnEmployee";
            this.ColumnEmployee.Width = 250;
            // 
            // ColumnPost
            // 
            this.ColumnPost.HeaderText = "Должность";
            this.ColumnPost.Name = "ColumnPost";
            this.ColumnPost.Width = 200;
            // 
            // ColumnWorkPhone
            // 
            this.ColumnWorkPhone.HeaderText = "Рабочий телефон";
            this.ColumnWorkPhone.Name = "ColumnWorkPhone";
            this.ColumnWorkPhone.Width = 150;
            // 
            // ColumnNormShift
            // 
            this.ColumnNormShift.HeaderText = "Норма смены";
            this.ColumnNormShift.Name = "ColumnNormShift";
            // 
            // ColumnOpenShift
            // 
            this.ColumnOpenShift.HeaderText = "Начало смены";
            this.ColumnOpenShift.Name = "ColumnOpenShift";
            this.ColumnOpenShift.Width = 120;
            // 
            // ColumnCloseShift
            // 
            this.ColumnCloseShift.HeaderText = "Конец смены";
            this.ColumnCloseShift.Name = "ColumnCloseShift";
            this.ColumnCloseShift.Width = 120;
            // 
            // ColumnStatusShift
            // 
            this.ColumnStatusShift.HeaderText = "Статус смены";
            this.ColumnStatusShift.Name = "ColumnStatusShift";
            // 
            // ShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 580);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ShiftForm";
            this.Text = "Смены";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPost;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWorkPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNormShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOpenShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCloseShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatusShift;
    }
}