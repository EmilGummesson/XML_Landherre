using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TenantMVP1.Models;

namespace TenantMVP1.Controllers
{
    public class ServiceCaseController : Controller
    {
        // GET: ServiceCase
        public ActionResult Index()
        {
            /*IList<ServiceCase> serviceCaseList = new List<ServiceCase>()
            {
                new ServiceCase() { CaseNr = 1, Date = DateTime.Now, FlatNr = 1, Name = "ServiceCase1", ContactEmail = "Email1@email.com"},
                new ServiceCase() { CaseNr = 2, Date = DateTime.Now, FlatNr = 2, Name = "ServiceCase1", ContactEmail = "Email2@email.com"},
                new ServiceCase() { CaseNr = 3, Date = DateTime.Now, FlatNr = 3, Name = "ServiceCase1", ContactEmail = "Email3@email.com"},
            };
            */
            var serviceCaseList = new List<ServiceCase>
            {
                new ServiceCase() { CaseNr = 1, Date = DateTime.Now, FlatNr = 1, Name = "ServiceCase1", ContactEmail = "Email1@email.com"},
                new ServiceCase() { CaseNr = 2, Date = DateTime.Now, FlatNr = 2, Name = "ServiceCase2", ContactEmail = "Email2@email.com"},
                new ServiceCase() { CaseNr = 3, Date = DateTime.Now, FlatNr = 3, Name = "ServiceCase3", ContactEmail = "Email3@email.com"},
            };

            return View(serviceCaseList);
        }
    }
}