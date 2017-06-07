using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EduCommerce.Web.Controllers
{
    public class BayilerController : Controller
    {
        KariyerPoliklinikDBEntities islemler = new KariyerPoliklinikDBEntities();
        // GET: Bayiler
        public ActionResult Index()
        {
            List<Dealers> bayiler = (from p in islemler.Dealers
                                     select p).ToList();
                                   
            return View(bayiler);
        }
    }
}