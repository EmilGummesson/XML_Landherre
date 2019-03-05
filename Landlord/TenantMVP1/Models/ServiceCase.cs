using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TenantMVP1.Models
{
    public class ServiceCase
    {
        public int CaseNr { get; set; } // sätts automatiskt av webbservicen vid sparning 

        public DateTime Date { get; set; } // sätts automatiskt av webbservicen vid sparning 

        public int FlatNr { get; set; } // optional 

        public string Name { get; set; } // optional 

        public string ContactEmail { get; set; } // obligatory 

        //public List<ServiceCasePost> Posts { get; set; }
    }
}