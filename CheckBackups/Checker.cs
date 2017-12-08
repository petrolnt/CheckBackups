using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32.TaskScheduler;

/// <summary>
///Статический класс методы которого преобразуют строку имени файла в зависимости от текущей даты, выполняют проверку существования данного файла или папки а также определяют его размер
/// </summary>

namespace CheckBackups
{
    static class Checker
    {
        /// <summary>
        /// метод выполняет преобразование заданной строки вида: c:\path_to_fileObject\{-x(dd_mm_yyyy_somestring.ext)}, где x количество дней вычитаемых из текущей даты, представленное целым числом
        /// somestring - любая строка, .exp - какое либо расширение файла. Например c:\backupfolder\{-1(dd_mm_yyyy)}_backupfile.zip будет преобразовано в 
        /// c:\backupfolder\25_09_2013_backupfile.zip если задача будет запущена 26.09.2013. После преобразования строки по указанному пути будет выполнена проверка существования файла и возвращен массив с данными
        /// о результате проверки(true или false о нахождении файла, его размер и полное имя файла с путем.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>

       
        

        public static object[] searchFileObject(String str, bool isFile)
        {
            object[] result = new object[3];
            long backupSize = 0;
            bool isBackupObjectExist = false;
            try
            {
                int dec = 0;
                //ищем вхождение регулярного выражения
                int index = str.IndexOf('{');
                //если оно есть
                if (index != -1)
                {
                    int index1 = str.IndexOf('(');
                    String subDec = str.Substring(index + 1, index1 - index - 1);
                    String subExt = str.Substring(str.IndexOf('}') + 1);
                    String subDate = str.Substring(index1 + 1, (str.IndexOf(')') - index1 - 1));
                    try
                    {
                        dec = int.Parse(subDec);
                    }
                    catch (FormatException sfe)
                    {
                        dec = 0;
                    }
                    DateTime currentDate = DateTime.Now;
                    DateTime backupDate = currentDate.AddDays(dec);
                    string date = backupDate.ToString(subDate);
                    str = str.Substring(0, index) + date + subExt;
                }
                if (isFile)
                {
                    if (File.Exists(str))
                    {
                        isBackupObjectExist = true;
                        FileInfo fI = new FileInfo(str);
                        backupSize = fI.Length / 1024 / 1024;
                    }
                }
                else
                {
                    if (Directory.Exists(str))
                    {
                        backupSize = DirSize(new DirectoryInfo(str)) / 1024 / 1024;
                        isBackupObjectExist = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Program.Logger(ex.Message + "/n" + ex.StackTrace + "/n");
            }

            result[0] = isBackupObjectExist;
            result[1] = backupSize;
            result[2] = str;
            return result;
        }

        public static long DirSize(DirectoryInfo dir)
        {
            return dir.GetFiles().Sum(fi => fi.Length) + dir.GetDirectories().Sum(di => DirSize(di));
        }

        //отправка сообщения по электронной почте
        public static void sendEmail(string reportName, string dataTable)
        {
            try
            {

                MailMessage mail = new MailMessage();
                SmtpClient client = new SmtpClient( Properties.Settings.Default.MailServer);
                mail.From = new MailAddress( Properties.Settings.Default.MailFrom);
                mail.To.Add(Properties.Settings.Default.RecipientsList);
                mail.Subject = reportName;
                mail.IsBodyHtml = true;
                StringBuilder htmlBody = new StringBuilder("<html><head><meta charset=\"utf-8\"><title></title><style>table {width: %; border: 1px solid #4682B4; border-spacing: 7px 5px; }th {background: #BEBEBE; } td {background: #F8F8FF; border: 1px solid #333; padding: 5px; }</style></head><h1>" + reportName + "</h1><br>");
                htmlBody.AppendFormat(dataTable);
                htmlBody.AppendFormat("</html>");
                mail.Body = htmlBody.ToString();
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                client.Send(mail);
            }

            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Logger(ex.Message + "/n" + ex.StackTrace + "/n");
            }
        }


    }
}
