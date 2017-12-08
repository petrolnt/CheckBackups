namespace CheckBackups
{
    partial class FormSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMailServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbRecipients = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbReportsFile = new System.Windows.Forms.TextBox();
            this.btnChooseReportFile = new System.Windows.Forms.Button();
            this.ofdReports = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Настройка отправки отчетов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Почтовый сервер";
            // 
            // tbMailServer
            // 
            this.tbMailServer.Location = new System.Drawing.Point(13, 50);
            this.tbMailServer.Name = "tbMailServer";
            this.tbMailServer.Size = new System.Drawing.Size(259, 20);
            this.tbMailServer.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отправитель";
            // 
            // tbSender
            // 
            this.tbSender.Location = new System.Drawing.Point(13, 94);
            this.tbSender.Name = "tbSender";
            this.tbSender.Size = new System.Drawing.Size(259, 20);
            this.tbSender.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Список получателей";
            // 
            // tbRecipients
            // 
            this.tbRecipients.Location = new System.Drawing.Point(16, 143);
            this.tbRecipients.Multiline = true;
            this.tbRecipients.Name = "tbRecipients";
            this.tbRecipients.Size = new System.Drawing.Size(256, 87);
            this.tbRecipients.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(197, 301);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(116, 301);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Файл конфигурации отчетов";
            // 
            // tbReportsFile
            // 
            this.tbReportsFile.Location = new System.Drawing.Point(16, 272);
            this.tbReportsFile.Name = "tbReportsFile";
            this.tbReportsFile.Size = new System.Drawing.Size(211, 20);
            this.tbReportsFile.TabIndex = 10;
            // 
            // btnChooseReportFile
            // 
            this.btnChooseReportFile.Location = new System.Drawing.Point(233, 270);
            this.btnChooseReportFile.Name = "btnChooseReportFile";
            this.btnChooseReportFile.Size = new System.Drawing.Size(39, 23);
            this.btnChooseReportFile.TabIndex = 11;
            this.btnChooseReportFile.Text = "...";
            this.btnChooseReportFile.UseVisualStyleBackColor = true;
            this.btnChooseReportFile.Click += new System.EventHandler(this.btnChooseReportFile_Click);
            // 
            // ofdReports
            // 
            this.ofdReports.DefaultExt = "xml";
            this.ofdReports.FileName = "reports.xml";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 336);
            this.Controls.Add(this.btnChooseReportFile);
            this.Controls.Add(this.tbReportsFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tbRecipients);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMailServer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMailServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRecipients;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbReportsFile;
        private System.Windows.Forms.Button btnChooseReportFile;
        private System.Windows.Forms.OpenFileDialog ofdReports;
    }
}