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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            tbMailServer.Text = Properties.Settings.Default.MailServer;
            tbRecipients.Text = Properties.Settings.Default.RecipientsList;
            tbSender.Text = Properties.Settings.Default.MailFrom;
            tbReportsFile.Text = Properties.Settings.Default.ReportFile;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MailServer = tbMailServer.Text;
            Properties.Settings.Default.MailFrom = tbSender.Text;
            Properties.Settings.Default.RecipientsList = tbRecipients.Text;
            Properties.Settings.Default.ReportFile = tbReportsFile.Text;
            Properties.Settings.Default.Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChooseReportFile_Click(object sender, EventArgs e)
        {
            if(ofdReports.ShowDialog() == DialogResult.OK)
            tbReportsFile.Text = ofdReports.FileName;
        }
    }
}
