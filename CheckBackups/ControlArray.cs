using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckBackups
{
    class ControlArray : ArrayList
    {
        Button btnEdit;
        Button btnDelete;
        Report report;
        ReportObject reportObject;

        //public ControlArray(List<Report> reports)
        //{
        //    foreach (Report report in reports)
        //    {
        //        String name = report.Name;
        //        Label lblName = new Label();
        //        lblName.Name = name;
        //        lblName.Text = name;
        //        lblName.Font = new Font(lblName.Font.FontFamily.Name, 10);
        //        lblName.AutoSize = true;
        //        Button btnEdit = new Button();
        //        btnEdit.Text = "Изменить";
        //        btnEdit.Name = name;
        //        btnEdit.Click += new System.EventHandler(btnEdit_Click);
        //        Button btnDelete = new Button();
        //        btnDelete.Text = "Удалить";
        //        btnDelete.Name = name;
        //    }

        //}

        public ControlArray(List<ReportObject> objects)
        {

        }
    }
}
