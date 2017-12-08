using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace CheckBackups
{
    public class Report
    {
        String id;
        List<ReportObject> reportObjects;
        public Report()
        {
            this.ReportObjects = new List<ReportObject>();
        }
        public Report(String name, List<ReportObject> reportObjects)
        {
            this.Name = name;
            this.ReportObjects = reportObjects;
        }
        [XmlAttribute("name")]
        public String Name
        {
            get;
            set;
        }

        [XmlAttribute("id")]
        public String Id
        {
            get
            {
                
                return id;
            }
            set
            {
                id = value;
            }
        }

        [XmlElement("reportObject")]
        public List<ReportObject> ReportObjects { get; set; }

        //public void addObject(ReportObject reportObj)
        //{
        //    reportObjects.Add(reportObj);
        //}

    }



}
