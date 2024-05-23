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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpEmployee = new System.Windows.Forms.FlowLayoutPanel();
            this.lstEmployee = new System.Windows.Forms.ListView();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grpList);
            this.panel1.Controls.Add(this.lstEmployee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 524);
            this.panel1.TabIndex = 0;
            // 
            // flpEmployee
            // 
            this.flpEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpEmployee.Location = new System.Drawing.Point(216, 0);
            this.flpEmployee.Name = "flpEmployee";
            this.flpEmployee.Size = new System.Drawing.Size(666, 524);
            this.flpEmployee.TabIndex = 1;
            // 
            // lstEmployee
            // 
            this.lstEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEmployee.HideSelection = false;
            this.lstEmployee.Location = new System.Drawing.Point(0, 0);
            this.lstEmployee.Name = "lstEmployee";
            this.lstEmployee.Size = new System.Drawing.Size(216, 524);
            this.lstEmployee.TabIndex = 0;
            this.lstEmployee.UseCompatibleStateImageBehavior = false;
            // 
            // grpList
            // 
            this.grpList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpList.Location = new System.Drawing.Point(0, 0);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(216, 100);
            this.grpList.TabIndex = 2;
            this.grpList.TabStop = false;
            this.grpList.Text = "Отображать в списке";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список сотрудников";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 524);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(882, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 546);
            this.Controls.Add(this.flpEmployee);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "EmployeesForm";
            this.Text = "Просмотр (редактирование) данных сотрудника";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpEmployee;
        private System.Windows.Forms.ListView lstEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}