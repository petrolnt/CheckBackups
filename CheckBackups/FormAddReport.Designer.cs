namespace CheckBackups
{
    partial class FormAddReport
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnCheckedObjects = new System.Windows.Forms.Panel();
            this.tlObjects = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveReport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddObject = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnTask = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTrigger = new System.Windows.Forms.Label();
            this.pnCheckedObjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя отчета";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(13, 30);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(526, 20);
            this.tbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Проверяемые обьекты";
            // 
            // pnCheckedObjects
            // 
            this.pnCheckedObjects.AutoScroll = true;
            this.pnCheckedObjects.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnCheckedObjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCheckedObjects.Controls.Add(this.tlObjects);
            this.pnCheckedObjects.Location = new System.Drawing.Point(16, 107);
            this.pnCheckedObjects.Name = "pnCheckedObjects";
            this.pnCheckedObjects.Size = new System.Drawing.Size(523, 142);
            this.pnCheckedObjects.TabIndex = 3;
            // 
            // tlObjects
            // 
            this.tlObjects.AutoSize = true;
            this.tlObjects.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tlObjects.ColumnCount = 3;
            this.tlObjects.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlObjects.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlObjects.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlObjects.Location = new System.Drawing.Point(-1, -1);
            this.tlObjects.Name = "tlObjects";
            this.tlObjects.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.tlObjects.RowCount = 2;
            this.tlObjects.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlObjects.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlObjects.Size = new System.Drawing.Size(520, 63);
            this.tlObjects.TabIndex = 0;
            // 
            // btnSaveReport
            // 
            this.btnSaveReport.Location = new System.Drawing.Point(383, 255);
            this.btnSaveReport.Name = "btnSaveReport";
            this.btnSaveReport.Size = new System.Drawing.Size(75, 23);
            this.btnSaveReport.TabIndex = 4;
            this.btnSaveReport.Text = "Сохранить";
            this.btnSaveReport.UseVisualStyleBackColor = true;
            this.btnSaveReport.Click += new System.EventHandler(this.btnSaveReport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(464, 255);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddObject
            // 
            this.btnAddObject.Location = new System.Drawing.Point(507, 78);
            this.btnAddObject.Name = "btnAddObject";
            this.btnAddObject.Size = new System.Drawing.Size(32, 23);
            this.btnAddObject.TabIndex = 6;
            this.btnAddObject.Text = "+";
            this.btnAddObject.UseVisualStyleBackColor = true;
            this.btnAddObject.Click += new System.EventHandler(this.btnAddObject_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(16, 255);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 7;
            this.btnRun.Text = "Проверить";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnTask
            // 
            this.btnTask.Location = new System.Drawing.Point(97, 255);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(97, 23);
            this.btnTask.TabIndex = 8;
            this.btnTask.Text = "Запланировать";
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Время выполнения:";
            // 
            // lblTrigger
            // 
            this.lblTrigger.AutoSize = true;
            this.lblTrigger.ForeColor = System.Drawing.Color.Red;
            this.lblTrigger.Location = new System.Drawing.Point(127, 64);
            this.lblTrigger.Name = "lblTrigger";
            this.lblTrigger.Size = new System.Drawing.Size(124, 13);
            this.lblTrigger.TabIndex = 10;
            this.lblTrigger.Text = "отчет не запланирован";
            this.lblTrigger.Click += new System.EventHandler(this.lblTrigger_Click);
            // 
            // FormAddReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 287);
            this.Controls.Add(this.lblTrigger);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTask);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnAddObject);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSaveReport);
            this.Controls.Add(this.pnCheckedObjects);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "FormAddReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактирование отчета";
            this.pnCheckedObjects.ResumeLayout(false);
            this.pnCheckedObjects.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnCheckedObjects;
        private System.Windows.Forms.Button btnSaveReport;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddObject;
        private System.Windows.Forms.TableLayoutPanel tlObjects;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTrigger;
    }
}