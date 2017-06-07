using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EduCommerce.Web.Controllers
{
    public class EgitimciController : Controller
    {
        KariyerPoliklinikDBEntities islemler = new KariyerPoliklinikDBEntities();
        // GET: Egitimci
        public ActionResult Index()
        {
            List<Personel> personel = (from p in islemler.Personel
                                       select p).ToList();
                                      
            return View(personel);
        }
    }
}