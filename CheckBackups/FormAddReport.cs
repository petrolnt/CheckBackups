using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32.TaskScheduler;

namespace CheckBackups
{
    public partial class FormAddReport : Form
    {

        private Report report;
        private Reports reports;
        private List<ReportObject> reportObjects;
        private Boolean isNewReport;
        //Report newReport;
        MainForm mainForm;
        TaskFolder fld;
        TaskService ts;

        public FormAddReport(MainForm mainForm, Reports reports)
        {
            try
            {
                InitializeComponent();
                this.reports = reports;
                this.mainForm = mainForm;
                report = new Report();
                isNewReport = true;
                ts = new TaskService();
                fld = ts.RootFolder;
            }
            catch (Exception ex)
            {
                String message = ex.Message;
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Logger(ex.Message + "/n" + ex.StackTrace + "/n");
            }
        }

        public FormAddReport(MainForm mainForm, Reports reports, Report report)
        {
            try
            {
                isNewReport = false;
                this.mainForm = mainForm;
                this.report = report;
                this.reports = reports;
                InitializeComponent();
                tbName.Text = report.Name;
                reportObjects = report.ReportObjects;
                if (reportObjects != null)
                {
                    foreach (ReportObject ro in reportObjects)
                    {
                        tlpAddRow(ro);
                    }
                }

                ts = new TaskService();
                fld = ts.RootFolder;
                setSchedulLabel();
            }
            catch (Exception ex)
            {
                String message = ex.Message;
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Logger(ex.Message + "/n" + ex.StackTrace);
            }
        }

        public void setSchedulLabel()
        {
            Task task = searchTask(fld);
            if (task != null)
            {
                //время выполнения отчета
                string startBoundary = task.Definition.Triggers[0].StartBoundary.ToString();
                TimeSpan startTime = task.Definition.Triggers[0].StartBoundary.TimeOfDay;
                string sTime = string.Format("{0:D2}:{1:D2}", startTime.Hours, startTime.Minutes);
                Trigger trigger = task.Definition.Triggers[0];
                TaskTriggerType tType = trigger.TriggerType;
                string monthDays = String.Empty;
                //меняем цвет лэйбла с красного на синий
                lblTrigger.ForeColor = Color.Blue;
                //если задача выполняется один раз
                if (tType == TaskTriggerType.Time)
                {
                    lblTrigger.Text = "Однократно " + startBoundary;

                }
                //если это ежедневный отчет
                if (tType == TaskTriggerType.Daily)
                {
                    lblTrigger.Text = "Ежедневно " + sTime;
                }
                //ежемесячный
                if (tType == TaskTriggerType.Monthly)
                {

                    MonthlyTrigger mTrigger = (MonthlyTrigger)trigger;
                    foreach (int day in mTrigger.DaysOfMonth)
                    {
                        monthDays += day.ToString() + ", ";
                    }

                    lblTrigger.Text = "Ежемесячно в " + sTime + " в " + monthDays;
                }
            }
        }

        public Task searchTask(TaskFolder fld)
        {

            foreach (Task task in fld.Tasks)
            {
                if (task.Name.Equals("CheckBackups_" + report.Id))
                {
                    return task;
                }
            }
            foreach (TaskFolder sfld in fld.SubFolders)
                searchTask(sfld);
            return null;
        }

        public void tlpAddRow(ReportObject ro)
        {
            try
            {
                String roName = ro.Name;
                Label lbl = new Label();
                lbl.Name = roName;
                lbl.Text = roName;
                lbl.Font = new Font(lbl.Font.FontFamily.Name, 10);
                lbl.AutoSize = true;
                lbl.Margin = new Padding(0, 5, 0, 0);
                Button btnEdit = new Button();
                btnEdit.Text = "Изменить";
                btnEdit.Name = roName;
                btnEdit.Click += new System.EventHandler(btnEdit_Click);
                Button btnDelete = new Button();
                btnDelete.Text = "Удалить";
                btnDelete.Name = roName;
                btnDelete.Click += new System.EventHandler(btnDelete_Click);
                tlObjects.Controls.Add(lbl);
                tlObjects.Controls.Add(btnEdit);
                tlObjects.Controls.Add(btnDelete);
            }
            catch (Exception ex)
            {
                String message = ex.Message;
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Logger(ex.Message + "/n" + ex.StackTrace);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Button someDeleteButton = (Button)sender;
                String fileObjectName = someDeleteButton.Name;
                ReportObject reportObject = report.ReportObjects.Find(item => item.Name == fileObjectName);
                report.ReportObjects.Remove(reportObject);
                int index = tlObjects.Controls.IndexOf(someDeleteButton);
                tlObjects.Controls.RemoveAt(index);
                tlObjects.Controls.RemoveAt(index - 1);
                tlObjects.Controls.RemoveAt(index - 2);
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
                Control[] renamedControls = tlObjects.Controls.Find(oldName, true);
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Button someButton = sender as Button;
                String objectName = someButton.Name;
                ReportObject editedObject;
                if (isNewReport)
                {
                    editedObject = report.ReportObjects.Find(item => item.Name == objectName);
                }
                else
                {
                    editedObject = report.ReportObjects.Find(item => item.Name == objectName);
                }
                FormAddObject formEditObject = new FormAddObject(this, editedObject);
                formEditObject.ShowDialog();
            }
            catch (Exception ex)
            {
                String message = ex.Message;
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Logger(ex.Message + "/n" + ex.StackTrace);
            }
        }

        private string genId()
        {
            StringBuilder strId = new StringBuilder();

            Random random = new Random();
            char ch;
            for (int i = 0; i < 4; i++)
            {
                StringBuilder octet = new StringBuilder();
                for (int j = 0; j < 4; j++)
                {
                    ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                    octet.Append(ch);
                }
                if (i < 3)
                    strId.Append(octet + "-");
                else
                    strId.Append(octet);
            }
            return strId.ToString();
        }

        private void btnSaveReport_Click(object sender, EventArgs e)
        {
            try
            {
                String name = tbName.Text;
                if (isNewReport)
                {
                    if ((reports.ReportList.Find(item => item.Name == name)) == null)
                    {
                        report.Name = name;
                        report.Id = genId();
                        reports.ReportList.Add(report);
                        mainForm.tlpAddControls(report);
                        this.Close();
                    }
                    else
                    {
                        string message = "Отчет с именем " + name + "  существует! Сохраните отчет под другим именем.";
                        MessageBox.Show(message, "Сохранение отчета", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    String oldName = report.Name;
                    if ((reports.ReportList.Find(item => item.Name == name)) == null || name == oldName)
                    {
                        report.Name = name;
                        report.ReportObjects = reportObjects;
                        mainForm.tlpEditControls(oldName, report.Name);
                        this.Close();
                    }
                    else
                    {
                        string message = "Отчет с именем " + name + "  существует! Сохраните отчет под другим именем.";
                        MessageBox.Show(message, "Сохранение отчета", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnAddObject_Click(object sender, EventArgs e)
        {
            try
            {
                FormAddObject addObject = new FormAddObject(this, report);
                addObject.ShowDialog();
            }
            catch (Exception ex)
            {
                String message = ex.Message;
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Logger(ex.Message + "/n" + ex.StackTrace);
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
                Program.Logger(ex.Message + "/n" + ex.StackTrace);
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            HtmlTable dt = new HtmlTable(report.Name);
            dt.Columns.Add("Название");
            dt.Columns.Add("Расположение");
            dt.Columns.Add("Результат");
            dt.Columns.Add("Размер в мегабайтах");

            foreach (ReportObject ro in report.ReportObjects)
            {
                Object[] result = new Object[3];
                string strResult = "Не выполнен";
                result = Checker.searchFileObject(ro.Path, ro.IsFile);
                int size = Convert.ToInt32(result[1]);
                if (Convert.ToBoolean(result[0]) == true)
                {

                    if (size >= ro.ExpectedSizeMB)
                    {
                        strResult = "Выполнен";
                    }
                    else
                    {
                        strResult = "Размер меньше ожидаемого";
                    }
                }

                dt.Rows.Add(ro.Name, result[2], strResult, (size.ToString() + " Мб"));

            }

            string table = dt.getHtmlCode();
            CheckBackups.Checker.sendEmail(report.Name, table);
        }

        private void btnTask_Click(object sender, EventArgs e)
        {

            editTask();

        }

        private void lblTrigger_Click(object sender, EventArgs e)
        {
            editTask();
        }
        private void editTask()
        {
            Task task = searchTask(fld);
            if (task != null)
            {
                FormAddTask addTask = new FormAddTask(this, task, report.Name, report.Id);
                addTask.ShowDialog();
            }
            else
            {
                FormAddTask addTask = new FormAddTask(this, report.Name, report.Id);
                addTask.ShowDialog();
            }
        }
    }
}
