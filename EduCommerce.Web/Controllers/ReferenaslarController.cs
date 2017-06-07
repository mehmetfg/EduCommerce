using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EduCommerce.Web.Controllers
{
    public class ReferenaslarController : Controller
    {
        KariyerPoliklinikDBEntities islemler = new KariyerPoliklinikDBEntities();


        // GET: Referenaslar
        public ActionResult Index()
        {
            List<Reference> referanslar = (from p in islemler.Reference
                                           select p).ToList();
            return View(referanslar);
        }
    }
}