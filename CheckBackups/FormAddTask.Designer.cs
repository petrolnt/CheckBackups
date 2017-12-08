namespace CheckBackups
{
    partial class FormAddTask
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
            this.lblTaskName = new System.Windows.Forms.Label();
            this.rbMonthly = new System.Windows.Forms.RadioButton();
            this.rbEveryDay = new System.Windows.Forms.RadioButton();
            this.dtpDay = new System.Windows.Forms.DateTimePicker();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.rbRunOnce = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clbDays = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTaskName.Location = new System.Drawing.Point(8, 9);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(100, 20);
            this.lblTaskName.TabIndex = 0;
            this.lblTaskName.Text = "lblTaskName";
            // 
            // rbMonthly
            // 
            this.rbMonthly.AutoSize = true;
            this.rbMonthly.Location = new System.Drawing.Point(12, 103);
            this.rbMonthly.Name = "rbMonthly";
            this.rbMonthly.Size = new System.Drawing.Size(89, 17);
            this.rbMonthly.TabIndex = 1;
            this.rbMonthly.TabStop = true;
            this.rbMonthly.Text = "Ежемесячно";
            this.rbMonthly.UseVisualStyleBackColor = true;
            this.rbMonthly.CheckedChanged += new System.EventHandler(this.rbMonthly_CheckedChanged);
            // 
            // rbEveryDay
            // 
            this.rbEveryDay.AutoSize = true;
            this.rbEveryDay.Location = new System.Drawing.Point(12, 80);
            this.rbEveryDay.Name = "rbEveryDay";
            this.rbEveryDay.Size = new System.Drawing.Size(82, 17);
            this.rbEveryDay.TabIndex = 2;
            this.rbEveryDay.TabStop = true;
            this.rbEveryDay.Text = "Ежедневно";
            this.rbEveryDay.UseVisualStyleBackColor = true;
            // 
            // dtpDay
            // 
            this.dtpDay.Location = new System.Drawing.Point(12, 148);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(133, 20);
            this.dtpDay.TabIndex = 3;
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(151, 148);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(100, 20);
            this.dtpTime.TabIndex = 4;
            // 
            // rbRunOnce
            // 
            this.rbRunOnce.AutoSize = true;
            this.rbRunOnce.Location = new System.Drawing.Point(12, 57);
            this.rbRunOnce.Name = "rbRunOnce";
            this.rbRunOnce.Size = new System.Drawing.Size(72, 17);
            this.rbRunOnce.TabIndex = 5;
            this.rbRunOnce.TabStop = true;
            this.rbRunOnce.Text = "Один раз";
            this.rbRunOnce.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Периодичность выполнения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Начать:";
            // 
            // clbDays
            // 
            this.clbDays.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clbDays.CheckOnClick = true;
            this.clbDays.ColumnWidth = 110;
            this.clbDays.FormattingEnabled = true;
            this.clbDays.Location = new System.Drawing.Point(11, 199);
            this.clbDays.MultiColumn = true;
            this.clbDays.Name = "clbDays";
            this.clbDays.Size = new System.Drawing.Size(450, 124);
            this.clbDays.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Дни месяца:";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(305, 411);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 14;
            this.btnAddTask.Text = "Сохранить";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(386, 411);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Закрыть";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Запускать от имени:";
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(13, 375);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(132, 20);
            this.tbUserName.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Пользователь";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(163, 375);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(144, 20);
            this.tbPassword.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Пароль";
            // 
            // FormAddTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 440);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clbDays);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbRunOnce);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.dtpDay);
            this.Controls.Add(this.rbEveryDay);
            this.Controls.Add(this.rbMonthly);
            this.Controls.Add(this.lblTaskName);
            this.Name = "FormAddTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.RadioButton rbMonthly;
        private System.Windows.Forms.RadioButton rbEveryDay;
        private System.Windows.Forms.DateTimePicker dtpDay;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.RadioButton rbRunOnce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clbDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label6;
    }
}