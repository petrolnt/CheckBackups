using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace CheckBackups
{
    public partial class MainForm : Form
    {
        Reports reports;
        XmlSerializer serializer;
        String config = Properties.Settings.Default.ReportFile;
        bool isEdited;
        public MainForm()
        {
            try
            {
                InitializeComponent();
                serializer = new XmlSerializer(typeof(Reports));
                FileStream loadStream = new FileStream(config, FileMode.OpenOrCreate, FileAccess.ReadWrite);
                reports = (Reports)serializer.Deserialize(loadStream);
                loadStream.Close();
                //object[][] objects = new object[3][];

                foreach (Report report in reports.ReportList)
                {
                    tlpAddControls(report);
                }
            }
            catch (Exception ex)
            {
                String message = ex.Message;
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Logger(ex.Message + "/n" + ex.StackTrace);
            }

        }

        public void tlpAddControls(Report report)
        {
            try
            {
                String name = report.Name;
                Label lblName = new Label();
                lblName.Name = name;
                lblName.Text = name;
                lblName.Font = new Font(lblName.Font.FontFamily.Name, 10);
                lblName.AutoSize = true;
                lblName.Margin = new Padding(0, 5, 0, 0);
                Button btnEdit = new Button();
                btnEdit.Text = "Изменить";
                btnEdit.Name = name;
                btnEdit.Click += new System.EventHandler(btnEdit_Click);
                Button btnDelete = new Button();
                btnDelete.Text = "Удалить";
                btnDelete.Name = name;
                btnDelete.Click += new System.EventHandler(btnDelete_Click);
                pnReport.Controls.Add(lblName);
                pnReport.Controls.Add(btnEdit);
                pnReport.Controls.Add(btnDelete);
            }
            catch (Exception ex)
            {
                String message = ex.Message;
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Logger(ex.Message + "/n" + ex.StackTrace);
            }
        }



        public void tlpEditControls(String oldName, String newName)
        {
            try
            {
                Control[] renamedControls = pnReport.Controls.Find(oldName, true);
                foreach (Control c in renamedControls)
                {
                    if (c.GetType().Equals(new Label().GetType()))
                    {
                        c.Text = newName;
                    }
                    c.Name = newName;
                }
            }
            catch (Exception ex)
            {
                String message = ex.Message;
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Logger(ex.Message + "/n" + ex.StackTrace);
            }
        }

        private void saveConfig()
        {
            try
            {
                TextWriter writer = new StreamWriter(config);
                serializer.Serialize(writer, reports);
                String message = "Конфигурация успешно сохранена";
                MessageBox.Show(message, "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                writer.Close();
                isEdited = false;
            }
            catch (Exception ex)
            {
                String message = ex.Message;
                MessageBox.Show(message, "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Logger(ex.Message + "/n" + ex.StackTrace);
            }
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                isEdited = true;
                Button someButton = sender as Button;
                String reportName = someButton.Name;
                Report report = reports.ReportList.Find(item => item.Name == reportName);
                FormAddReport addReport = new FormAddReport(this, reports, report);
                addReport.ShowDialog();
            }
            catch (Exception ex)
            {
                String message = ex.Message;
                Console.WriteLine(ex.StackTrace);
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Logger(ex.Message + "/n" + ex.StackTrace);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Button someDeleteButton = (Button)sender;
                String reportName = someDeleteButton.Name;
                Report report = reports.ReportList.Find(item => item.Name == reportName);
                reports.ReportList.Remove(report);
                int index = pnReport.Controls.IndexOf(someDeleteButton);
                pnReport.Controls.RemoveAt(index);
                pnReport.Controls.RemoveAt(index - 1);
                pnReport.Controls.RemoveAt(index - 2);
            }
            catch (Exception ex)
            {
                String message = ex.Message;
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Logger(ex.Message + "/n" + ex.StackTrace);
            }
        }

        private void btnAddReport_Click(object sender, EventArgs e)
        {
            try
            {
                isEdited = true;
                FormAddReport formAddReport = new FormAddReport(this, reports);
                formAddReport.ShowDialog();
            }
            catch (Exception ex)
            {
                String message = ex.Message;
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Logger(ex.Message + "/n" + ex.StackTrace);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveConfig();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSettings settings = new FormSettings();
            settings.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void saveAndClose()
        {
            try
            {
                if (isEdited)
                {
                    DialogResult res = (MessageBox.Show("Сохранить конфигурацию перед закрытием?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                    if (res == DialogResult.Yes)
                    {
                        saveConfig();
                    }
                }            
            }
            catch (Exception ex)
            {
                String message = ex.Message;
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Logger(ex.Message + "/n" + ex.StackTrace);
            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveAndClose();
        }


    }
}
