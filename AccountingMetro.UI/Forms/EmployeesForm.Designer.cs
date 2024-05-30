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
            this.grpList = new System.Windows.Forms.GroupBox();
            this.cmbPost = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchFIO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbStation = new System.Windows.Forms.ComboBox();
            this.lblStation = new System.Windows.Forms.Label();
            this.cmbVetka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.flpEmployees = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.grpList.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Size = new System.Drawing.Size(257, 487);
            this.panel1.TabIndex = 0;
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.cmbPost);
            this.grpList.Controls.Add(this.label3);
            this.grpList.Controls.Add(this.txtSearchFIO);
            this.grpList.Controls.Add(this.label4);
            this.grpList.Controls.Add(this.cmbStation);
            this.grpList.Controls.Add(this.lblStation);
            this.grpList.Controls.Add(this.cmbVetka);
            this.grpList.Controls.Add(this.label1);
            this.grpList.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpList.Location = new System.Drawing.Point(7, 6);
            this.grpList.Margin = new System.Windows.Forms.Padding(4);
            this.grpList.Name = "grpList";
            this.grpList.Padding = new System.Windows.Forms.Padding(4);
            this.grpList.Size = new System.Drawing.Size(243, 356);
            this.grpList.TabIndex = 2;
            this.grpList.TabStop = false;
            this.grpList.Text = "Отображать в списке";
            // 
            // cmbPost
            // 
            this.cmbPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPost.DropDownWidth = 250;
            this.cmbPost.FormattingEnabled = true;
            this.cmbPost.Location = new System.Drawing.Point(9, 116);
            this.cmbPost.Margin = new System.Windows.Forms.Padding(5);
            this.cmbPost.Name = "cmbPost";
            this.cmbPost.Size = new System.Drawing.Size(225, 24);
            this.cmbPost.TabIndex = 13;
            this.cmbPost.SelectedIndexChanged += new System.EventHandler(this.cmbPost_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "По должности";
            // 
            // txtSearchFIO
            // 
            this.txtSearchFIO.Location = new System.Drawing.Point(9, 55);
            this.txtSearchFIO.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchFIO.Name = "txtSearchFIO";
            this.txtSearchFIO.Size = new System.Drawing.Size(225, 23);
            this.txtSearchFIO.TabIndex = 11;
            this.txtSearchFIO.TextChanged += new System.EventHandler(this.cmbPost_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Поиск по ФИО";
            // 
            // cmbStation
            // 
            this.cmbStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStation.FormattingEnabled = true;
            this.cmbStation.Location = new System.Drawing.Point(9, 239);
            this.cmbStation.Margin = new System.Windows.Forms.Padding(5);
            this.cmbStation.Name = "cmbStation";
            this.cmbStation.Size = new System.Drawing.Size(225, 24);
            this.cmbStation.TabIndex = 9;
            this.cmbStation.SelectedIndexChanged += new System.EventHandler(this.cmbPost_SelectedIndexChanged);
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(11, 217);
            this.lblStation.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(85, 16);
            this.lblStation.TabIndex = 8;
            this.lblStation.Text = "По станции";
            // 
            // cmbVetka
            // 
            this.cmbVetka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVetka.FormattingEnabled = true;
            this.cmbVetka.Location = new System.Drawing.Point(9, 177);
            this.cmbVetka.Margin = new System.Windows.Forms.Padding(5);
            this.cmbVetka.Name = "cmbVetka";
            this.cmbVetka.Size = new System.Drawing.Size(225, 24);
            this.cmbVetka.TabIndex = 7;
            this.cmbVetka.SelectedIndexChanged += new System.EventHandler(this.cmbPost_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "По ветке";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 487);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(960, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // flpEmployees
            // 
            this.flpEmployees.AutoScroll = true;
            this.flpEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpEmployees.Location = new System.Drawing.Point(257, 0);
            this.flpEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.flpEmployees.Name = "flpEmployees";
            this.flpEmployees.Size = new System.Drawing.Size(703, 487);
            this.flpEmployees.TabIndex = 3;
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 509);
            this.Controls.Add(this.flpEmployees);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Просмотр (редактирование) данных сотрудника";
            this.panel1.ResumeLayout(false);
            this.grpList.ResumeLayout(false);
            this.grpList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.FlowLayoutPanel flpEmployees;
        private System.Windows.Forms.TextBox txtSearchFIO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbStation;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.ComboBox cmbVetka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPost;
        private System.Windows.Forms.Label label3;
    }
}