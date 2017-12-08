using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CheckBackups
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>


        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                if (args.Length > 0)
                {
                    string reportId = args[0];
                    String config = Properties.Settings.Default.ReportFile;
                    XmlSerializer serializer = new XmlSerializer(typeof(Reports));
                    FileStream loadStream = new FileStream(config, FileMode.Open, FileAccess.Read);
                    Reports reports = (Reports)serializer.Deserialize(loadStream);
                    foreach (Report report in reports.ReportList)
                    {
                        if (reportId.Equals(report.Id))
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
                    }
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainForm());
                }
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.StackTrace, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Logger(ex.Message + "/n" + ex.StackTrace);
            }
        }
       public static void Logger(String str)
        {
           
            if (!EventLog.SourceExists("CheckBackups"))
            {
                EventLog.CreateEventSource("CheckBackups", "CheckBackupsLog");
            }
            EventLog myLog = new EventLog();
            myLog.Source = "CheckBackups";
            myLog.WriteEntry(str);
        }
    }
}
