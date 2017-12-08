using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CheckBackups
{
    class HtmlTable : DataTable
    {
        public HtmlTable() : base()
        {

        }
        public HtmlTable(String name)
            : base()
        {

        }
        public string getHtmlCode()
        {
            string htmlCode = "<table><tr>";
            foreach (DataColumn dc in this.Columns)
            {
                htmlCode += "<th>" + dc.ColumnName + "</th>";
            }

            htmlCode += "</tr>";

            foreach (DataRow dr in this.Rows)
            {
                htmlCode += "<tr>";
                foreach (DataColumn dc in this.Columns)
                {
                    htmlCode += "<td>" + dr[dc].ToString() + "</td>";

                }
                htmlCode += "</tr>";
            }
            htmlCode += "</table>";
            return htmlCode;
        }
    }
}
