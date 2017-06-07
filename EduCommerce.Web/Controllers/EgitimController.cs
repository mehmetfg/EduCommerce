using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EduCommerce.Web.Controllers
{
    public class EgitimController : Controller
    {
        KariyerPoliklinikDBEntities islemler = new KariyerPoliklinikDBEntities();
        // GET: EgitimDetay
        public ActionResult Index()
        {
            Educations egitim = (from p in islemler.Educations
                                       where p.ID == 1
                                       select p).FirstOrDefault();

            return View(egitim);
        }
        public ActionResult IlgiliEgitim()
        {

            return View();
        }
    }
}