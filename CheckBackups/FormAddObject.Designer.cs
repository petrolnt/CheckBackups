namespace CheckBackups
{
    partial class FormAddObject
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
            this.tbDisplayName = new System.Windows.Forms.TextBox();
            this.tbObjectPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChoosePath = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbExpectedSizeMB = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ofDialog = new System.Windows.Forms.OpenFileDialog();
            this.rbFile = new System.Windows.Forms.RadioButton();
            this.rbFolder = new System.Windows.Forms.RadioButton();
            this.fbDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отображаемое имя";
            // 
            // tbDisplayName
            // 
            this.tbDisplayName.Location = new System.Drawing.Point(13, 30);
            this.tbDisplayName.Name = "tbDisplayName";
            this.tbDisplayName.Size = new System.Drawing.Size(421, 20);
            this.tbDisplayName.TabIndex = 1;
            // 
            // tbObjectPath
            // 
            this.tbObjectPath.Location = new System.Drawing.Point(12, 109);
            this.tbObjectPath.Name = "tbObjectPath";
            this.tbObjectPath.Size = new System.Drawing.Size(422, 20);
            this.tbObjectPath.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Расположение файла или папки";
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.Location = new System.Drawing.Point(440, 107);
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(41, 23);
            this.btnChoosePath.TabIndex = 4;
            this.btnChoosePath.Text = "...";
            this.btnChoosePath.UseVisualStyleBackColor = true;
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Предполагаемый размер в мегабайтах";
            // 
            // tbExpectedSizeMB
            // 
            this.tbExpectedSizeMB.Location = new System.Drawing.Point(13, 162);
            this.tbExpectedSizeMB.Name = "tbExpectedSizeMB";
            this.tbExpectedSizeMB.Size = new System.Drawing.Size(421, 20);
            this.tbExpectedSizeMB.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(405, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(324, 208);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbFile
            // 
            this.rbFile.AutoSize = true;
            this.rbFile.Checked = true;
            this.rbFile.Location = new System.Drawing.Point(15, 57);
            this.rbFile.Name = "rbFile";
            this.rbFile.Size = new System.Drawing.Size(54, 17);
            this.rbFile.TabIndex = 9;
            this.rbFile.TabStop = true;
            this.rbFile.Text = "Файл";
            this.rbFile.UseVisualStyleBackColor = true;
            // 
            // rbFolder
            // 
            this.rbFolder.AutoSize = true;
            this.rbFolder.Location = new System.Drawing.Point(75, 57);
            this.rbFolder.Name = "rbFolder";
            this.rbFolder.Size = new System.Drawing.Size(57, 17);
            this.rbFolder.TabIndex = 10;
            this.rbFolder.TabStop = true;
            this.rbFolder.Text = "Папка";
            this.rbFolder.UseVisualStyleBackColor = true;
            // 
            // FormAddObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 242);
            this.Controls.Add(this.rbFolder);
            this.Controls.Add(this.rbFile);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbExpectedSizeMB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChoosePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbObjectPath);
            this.Controls.Add(this.tbDisplayName);
            this.Controls.Add(this.label1);
            this.Name = "FormAddObject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormAddObject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDisplayName;
        private System.Windows.Forms.TextBox tbObjectPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChoosePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbExpectedSizeMB;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog ofDialog;
        private System.Windows.Forms.RadioButton rbFile;
        private System.Windows.Forms.RadioButton rbFolder;
        private System.Windows.Forms.FolderBrowserDialog fbDialog;
    }
}