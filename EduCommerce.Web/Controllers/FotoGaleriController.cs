using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EduCommerce.Web.Controllers
{
    public class FotoGaleriController : Controller
    { KariyerPoliklinikDBEntities islemler = new KariyerPoliklinikDBEntities();
        // GET: FotoGaleri
        public ActionResult Index()
        {
            List<Media> fotograf = (from p in islemler.Media
                                    where p.Type == "1"
                                    select p).ToList();

            return View(fotograf);
        }
    }
}