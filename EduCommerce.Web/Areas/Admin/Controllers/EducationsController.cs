using EduCommerce.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EduCommerce.Web.Areas.Admin.Controllers
{
    public class EducationsController : Controller
    {
        KariyerPoliklinikDBEntities islemler = new KariyerPoliklinikDBEntities();
        // GET: Educations
        public ActionResult Index()
        {
            return RedirectToAction("ListEducation");
        }
        public ActionResult getEdu()
        {
            EducationCore eCore = new EducationCore();
            DataTable model = eCore.getAll();
            return View(model);
        }
        public ActionResult ListEducation()
        {
            List<Educations> Egitimler = (from p in islemler.Educations
                                          select p).ToList();


            return View(Egitimler);
        }
        public ActionResult Detay(int id)
        {
            Educations edu = (from p in islemler.Educations
                              where p.ID == id
                              select p).FirstOrDefault();
            ViewBag.ID = 1;
            return View(edu);
        }
        public ActionResult Yeni()
        {
          
                        

            return View();
        }
        [HttpPost]
        public ActionResult Yeni(Educations egitimler)
        {
            islemler.Educations.Add(egitimler);
            islemler.SaveChanges();

            
            return RedirectToAction("ListEducation");

        }

        public ActionResult Guncelle(int id)
        {
            ViewBag.Id = 1;
            Educations egitimler = (from p in islemler.Educations
                                    where p.ID == id
                                    select p).FirstOrDefault();
            return View(egitimler); 
        }
        [HttpPost]
      public ActionResult Guncelle(Educations egitimler)
        {
            Educations seciliEgitim = (from p in islemler.Educations
                                       where p.ID == egitimler.ID
                                       select p).FirstOrDefault();
            seciliEgitim.Name = egitimler.Name;
            seciliEgitim.Price = egitimler.Price;
            seciliEgitim.Time = egitimler.Time;
            seciliEgitim.University = egitimler.University;
            islemler.SaveChanges();
            return RedirectToAction("ListEducation");


        }
        public ActionResult Sil(int id)
        {
            Educations egitimler = (from p in islemler.Educations
                                    where p.ID == id
                                    select p).FirstOrDefault();
            return View(egitimler);
        }
        [HttpPost, ActionName("Sil")]
        public ActionResult SilmeIslemi(int id)
        {
            Educations silinecekEgitim = (from p in islemler.Educations
                                          where p.ID == id
                                          select p).FirstOrDefault();

            int egitimId = silinecekEgitim.ID;
            islemler.Educations.Remove(silinecekEgitim);
            islemler.SaveChanges();
            return RedirectToAction("ListEducation");



        }
    }
}