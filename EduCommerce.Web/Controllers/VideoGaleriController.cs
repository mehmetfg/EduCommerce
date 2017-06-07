using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EduCommerce.Web.Controllers
{
    public class VideoGaleriController : Controller
    {
        KariyerPoliklinikDBEntities islemler = new KariyerPoliklinikDBEntities();
        // GET: VideoGaleri
        public ActionResult Index()
        {
            List<Media> videolar = (from p in islemler.Media
                                    where p.Type == "2"
                                    select p).ToList();
            return View(videolar);
        }
    }
}