using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckBackups
{
    public partial class FormAddObject : Form
    {
        private List<ReportObject> reportObjects;
        private ReportObject reportObject;
        private Report report;
        private Boolean isNewObject;
        private FormAddReport mainForm;

        
        //конструктор для добавления нового обьекта со ссылкой на родительское окно и на отбьект Report к которому будет принадлежать обьект проверки
        public FormAddObject(FormAddReport mainForm, Report report)
        {
            try
            {
                InitializeComponent();
                this.mainForm = mainForm;
                this.report = report;
                isNewObject = true;
                //reportObjects = new List<ReportObject>();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Logger(ex.Message + "/n" + ex.StackTrace + "/n");
            }
        }

        //конструктор для редактирования выбранного обьекта со ссылкой на сам обьект и на родительское окно
        public FormAddObject(FormAddReport mainForm, ReportObject reportObject)
        {
            try
            {
                InitializeComponent();
                this.reportObject = reportObject;
                this.tbDisplayName.Text = reportObject.Name;
                this.tbObjectPath.Text = reportObject.Path;
                this.tbExpectedSizeMB.Text = (reportObject.ExpectedSizeMB).ToString();
                this.mainForm = mainForm;
                if (reportObject.IsFile == true)
                {
                    rbFile.Checked = true;
                }
                else
                {
                    rbFolder.Checked = true;
                }
                isNewObject = false;
            }
            catch (Exception ex)
            {
                String message = ex.Message;
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Logger(ex.Message + "/n" + ex.StackTrace + "/n");
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (isNewObject)
                {
                    reportObject = new ReportObject();
                    reportObject.Name = tbDisplayName.Text;
                    reportObject.Path = tbObjectPath.Text;
                    reportObject.ExpectedSizeMB = int.Parse(tbExpectedSizeMB.Text);
                    reportObject.IsFile = rbFile.Checked;
                    report.ReportObjects.Add(reportObject);
                    mainForm.tlpAddRow(reportObject);
                    this.Close();
                }

                else
                {
                    String oldName = reportObject.Name;
                    reportObject.Name = tbDisplayName.Text;
                    reportObject.Path = tbObjectPath.Text;
                    reportObject.ExpectedSizeMB = int.Parse(tbExpectedSizeMB.Text);
                    reportObject.IsFile = rbFile.Checked;
                    mainForm.tlpEditControls(oldName, reportObject.Name);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                String message = ex.Message;
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Logger(ex.Message + "/n" + ex.StackTrace + "/n");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                String message = ex.Message;
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Logger(ex.Message + "/n" + ex.StackTrace + "/n");
            }
        }

        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            if (rbFile.Checked)
            {
                if (ofDialog.ShowDialog() == DialogResult.OK)
                {
                    tbObjectPath.Text = ofDialog.FileName;
                }
            }

            if (rbFolder.Checked)
            {
                if (fbDialog.ShowDialog() == DialogResult.OK)
                {
                    tbObjectPath.Text = fbDialog.SelectedPath;
                }
            }
        }
    }
}
