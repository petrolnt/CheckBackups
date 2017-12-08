using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace CheckBackups
{

    [XmlRoot("reports"), Serializable]
    public class Reports

    {
      //  List<Report> reportList;

        //public int Count
        //{
        //    get { return ReportList.Count; }
        //}
        [XmlElement("report")]
        public List<Report> ReportList {
            get; set;
        }

        //public void addReport(Report report)
        //{
        //    ReportList.Add(report);
        //}
    }

   
}
