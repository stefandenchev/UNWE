using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISDA_WebApp.Models
{
    public class Student
    {
        public string FNumber { get; set; }
        public int SpecialtyId { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
    }
}