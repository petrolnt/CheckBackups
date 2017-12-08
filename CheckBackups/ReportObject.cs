using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Text.RegularExpressions;

namespace CheckBackups
{
    public class ReportObject
    {
        [XmlAttribute("name")]
        public String Name { get; set; }
        [XmlAttribute("path")]
        public String Path{get; set;}
        [XmlAttribute("expectedSizeMB")]
        public int ExpectedSizeMB { get; set; }
        [XmlAttribute("isFile")]
        public bool IsFile { get; set; }
    }
}
