using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace EduCommerce.Web.Controllers
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
            List<Educations> Egitimler = (from p in islemler.Educations
                                          select p).ToList();


            return View(Egitimler);         
        }
        public ActionResult GetFoto()
        {
            List<Media> Fotograflar = (from p in islemler.Media
                                       where p.Type == "1"
                                       select p).ToList();
            return View(Fotograflar);

        }
        public ActionResult GetVideo()
        {
            List<Media> videolar = (from p in islemler.Media
                                    where p.Type == "2"
                                    select p).ToList();


            return View(videolar);


        }
        public ActionResult GetYorum()
        {
            List<Comment> yorum = (from p in islemler.Comment
                                   select p).ToList();
            return View(yorum);

        }
        public ActionResult GetBayiTop()
        {

            Dealers model = getBayi();
            return View(model);
        }
        public ActionResult GetBayiFooter()
        {
            Dealers model = getBayi();
            return View(model);
        }

        public Dealers getBayi()
        {
            Dealers bayi = (from p in islemler.Dealers
                            where p.ID == 17
                            select p).FirstOrDefault();
            return bayi;
        }
    }
}