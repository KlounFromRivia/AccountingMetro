namespace AccountingMetro.UI.UserControls
{
    partial class EmployeeView
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblFIO = new System.Windows.Forms.Label();
            this.lblPost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStation = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTrain = new System.Windows.Forms.Label();
            this.lblTrains = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiViewShift = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStatus = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО сотрудника:";
            // 
            // lblFIO
            // 
            this.lblFIO.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFIO.Location = new System.Drawing.Point(10, 32);
            this.lblFIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFIO.Name = "lblFIO";
            this.lblFIO.Size = new System.Drawing.Size(199, 50);
            this.lblFIO.TabIndex = 1;
            this.lblFIO.Text = "Фамилия Имя Отчество";
            // 
            // lblPost
            // 
            this.lblPost.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPost.Location = new System.Drawing.Point(10, 104);
            this.lblPost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(199, 44);
            this.lblPost.TabIndex = 3;
            this.lblPost.Text = "Дежурный";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Должность:";
            // 
            // lblStation
            // 
            this.lblStation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStation.Location = new System.Drawing.Point(10, 170);
            this.lblStation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(199, 35);
            this.lblStation.TabIndex = 5;
            this.lblStation.Text = "Станция";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Станция:";
            // 
            // lblTrain
            // 
            this.lblTrain.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTrain.Location = new System.Drawing.Point(10, 227);
            this.lblTrain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrain.Name = "lblTrain";
            this.lblTrain.Size = new System.Drawing.Size(199, 20);
            this.lblTrain.TabIndex = 7;
            this.lblTrain.Text = "5345";
            // 
            // lblTrains
            // 
            this.lblTrains.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTrains.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTrains.Location = new System.Drawing.Point(10, 205);
            this.lblTrains.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrains.Name = "lblTrains";
            this.lblTrains.Size = new System.Drawing.Size(199, 22);
            this.lblTrains.TabIndex = 6;
            this.lblTrains.Text = "Поезд:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdit,
            this.tsmiViewShift,
            this.tsmiDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(214, 70);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(213, 22);
            this.tsmiEdit.Text = "Просмотр данных";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // tsmiViewShift
            // 
            this.tsmiViewShift.Name = "tsmiViewShift";
            this.tsmiViewShift.Size = new System.Drawing.Size(213, 22);
            this.tsmiViewShift.Text = "Просмотр смен";
            this.tsmiViewShift.Click += new System.EventHandler(this.tsmiViewShift_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(213, 22);
            this.tsmiDelete.Text = "Удалить сотрудника";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatus.Location = new System.Drawing.Point(10, 249);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(199, 20);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Уволен";
            this.lblStatus.Visible = false;
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblTrain);
            this.Controls.Add(this.lblTrains);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFIO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(219, 279);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFIO;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTrain;
        private System.Windows.Forms.Label lblTrains;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiViewShift;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
    }
}
