using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace EduCommerce.Web.Areas.Web.Controllers
{
    public class DefaultController : Controller
    {
        KariyerPoliklinikDBEntities islemler = new KariyerPoliklinikDBEntities();
        // GET: Web/Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult getEdu()
        {
            List<Educations> Ogrenciler = (from p in islemler.Educations
                                           select p).ToList();
            return View(Ogrenciler);
        }
    }
}