using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32.TaskScheduler;
//using TaskScheduler;

namespace CheckBackups
{
    public partial class FormAddTask : Form
    {
        string taskName;
        string taskId;
        FormAddReport mainForm;
        public FormAddTask(FormAddReport mainForm, string taskName, string taskId)
        {
            InitializeComponent();
            this.taskName = taskName;
            this.taskId = taskId;
            this.mainForm = mainForm;
            lblTaskName.Text = taskName;
            for (int i = 1; i < 32; i++)
            {
                clbDays.Items.Add(i.ToString());
            }
            clbDays.Enabled = false;
        }

        public FormAddTask(FormAddReport mainForm, Task task, string taskName, string taskId)
        {
            try
            {
                InitializeComponent();
                taskName = task.Name;
                this.taskId = taskId;
                this.mainForm = mainForm;
                lblTaskName.Text = taskName;
                for (int i = 1; i < 32; i++)
                {
                    clbDays.Items.Add(i.ToString());
                }
                clbDays.Enabled = false;
                TaskTriggerType tType = task.Definition.Triggers[0].TriggerType;
                if (tType == TaskTriggerType.Time)
                    rbRunOnce.Checked = true;
                if (tType == TaskTriggerType.Daily)
                    rbEveryDay.Checked = true;
                if (tType == TaskTriggerType.Monthly)
                {
                    rbMonthly.Checked = true;
                    MonthlyTrigger monTrigger = (MonthlyTrigger)task.Definition.Triggers[0];

                    foreach (int day in monTrigger.DaysOfMonth)
                    {
                        clbDays.SetItemCheckState(day - 1, CheckState.Checked);
                    }
                }
                dtpDay.Value = task.Definition.Triggers[0].StartBoundary.Date;
                dtpTime.Value = new DateTime(1970, 1, 1).Add(task.Definition.Triggers[0].StartBoundary.TimeOfDay);
            }
            catch(Exception ex)
            {
                Program.Logger(ex.Message + "/n" + ex.StackTrace);
            }
        }

        private void addTask(Trigger trigger)
        {
            try
            {
                string path = Environment.CurrentDirectory;
                TaskService ts = new TaskService();
                ExecAction action = new ExecAction(path + @"\CheckBackups.exe", taskId, @"c:\");
                Task task = ts.AddTask("CheckBackups_" + taskId, trigger, action, tbUserName.Text, tbPassword.Text);

                if (task != null)
                {
                    MessageBox.Show("Задача успешно сохранена");
                }
                else
                {

                    MessageBox.Show("Ошибка сохранения задачи!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                TaskDefinition td = task.Definition;
                td.Principal.UserId = tbUserName.Text;
                //td.Principal.LogonType = TaskLogonType.Password;
                td.Principal.RunLevel = TaskRunLevel.Highest;
                TaskFolder tf = ts.RootFolder;
                tf.RegisterTaskDefinition("CheckBackups_" + taskId, td, TaskCreation.CreateOrUpdate, tbUserName.Text, tbPassword.Text, TaskLogonType.Password);
                task.RegisterChanges();
                mainForm.setSchedulLabel();
            }
            catch(Exception ex)
            {
                Program.Logger(ex.Message + "/n" + ex.StackTrace);
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            
           
            if (rbRunOnce.Checked)
            {
               TimeTrigger tTrigger = new TimeTrigger();
                tTrigger.StartBoundary = dtpDay.Value.Date + dtpTime.Value.TimeOfDay;
                addTask(tTrigger);
            }

            if(rbEveryDay.Checked)
            {
                DailyTrigger dTrigger = new DailyTrigger();
                dTrigger.StartBoundary = dtpDay.Value.Date + dtpTime.Value.TimeOfDay;
               dTrigger.DaysInterval = 1;
               addTask(dTrigger);
            }

            if(rbMonthly.Checked)
            {
                int countIndexes = clbDays.CheckedIndices.Count;
                int[] days = new int[countIndexes];
                int i = 0;
                foreach (int indexChecked in clbDays.CheckedIndices)
                {
                    days[i] = indexChecked + 1;
                    i++;
                }
                MonthlyTrigger mTrigger = new MonthlyTrigger();
                mTrigger.DaysOfMonth = days;
                addTask(mTrigger);
            }
        }

        private void rbMonthly_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMonthly.Checked)
            {
                clbDays.Enabled = true;
            }
            else
            {
                clbDays.Enabled = false;
                
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
                Program.Logger(ex.Message + "/n" + ex.StackTrace);
            }
        }
    }
}
