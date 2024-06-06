namespace AccountingMetro.UI.UserControls
{
    partial class StaffDepartView
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblStation = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFIO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiViewData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDeleteStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStation
            // 
            this.lblStation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStation.Location = new System.Drawing.Point(10, 104);
            this.lblStation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(208, 35);
            this.lblStation.TabIndex = 12;
            this.lblStation.Text = "Дежурный";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Станция:";
            // 
            // lblFIO
            // 
            this.lblFIO.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFIO.Location = new System.Drawing.Point(10, 32);
            this.lblFIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFIO.Name = "lblFIO";
            this.lblFIO.Size = new System.Drawing.Size(208, 50);
            this.lblFIO.TabIndex = 10;
            this.lblFIO.Text = "Фамилия Имя Отчество";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "ФИО сотрудника:";
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(10, 207);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(208, 20);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Уволен";
            this.lblStatus.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditStaff,
            this.tsmiViewData,
            this.tsmiDeleteStaff});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(230, 92);
            // 
            // tsmiViewData
            // 
            this.tsmiViewData.Name = "tsmiViewData";
            this.tsmiViewData.Size = new System.Drawing.Size(229, 22);
            this.tsmiViewData.Text = "Просмотр данных";
            this.tsmiViewData.Click += new System.EventHandler(this.tsmiViewData_Click);
            // 
            // tsmiDeleteStaff
            // 
            this.tsmiDeleteStaff.Name = "tsmiDeleteStaff";
            this.tsmiDeleteStaff.Size = new System.Drawing.Size(229, 22);
            this.tsmiDeleteStaff.Text = "Удалить сотрудника";
            this.tsmiDeleteStaff.Click += new System.EventHandler(this.tsmiDeleteStaff_Click);
            // 
            // tsmiEditStaff
            // 
            this.tsmiEditStaff.Name = "tsmiEditStaff";
            this.tsmiEditStaff.Size = new System.Drawing.Size(229, 22);
            this.tsmiEditStaff.Text = "Редактирование сотрудника";
            // 
            // StaffDepartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFIO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StaffDepartView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(228, 237);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewData;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteStaff;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditStaff;
    }
}
