using EduCommerce.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EduCommerce.Web.Controllers
{
    public class EducationsController : Controller
    {
        KariyerPoliklinikDBEntities islemler = new KariyerPoliklinikDBEntities();
        // GET: Educations
        public ActionResult Index()
        {
            EducationCore eCore = new EducationCore();
            DataTable model = eCore.getAll();
            return View(model);
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
        public ActionResult DetailEducation(int id)
        {
            Educations edu = (from p in islemler.Educations
                              where p.ID == id
                              select p).FirstOrDefault();
            ViewBag.ID = 1;
            return View(edu);
        }
        public ActionResult Yeni()
        {
            //var bolumler = islimler.Educations.ToList().Select(b => new

            //  SelectListItem
            //{
            //    Selected = false,
            //    Text = b.Name,
            //    Value = b.ID.ToString()

            //}).ToString();
            //ViewBag.Bolumler = bolumler;
                        

            return View();
        }
        [HttpPost]
        public ActionResult Yeni(Educations egitimler)
        {
            islemler.Educations.Add(egitimler);
            islemler.SaveChanges();

            RedirectToAction("ListEducation");
            return View();

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
            return View();


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
            return RedirectToAction("Educations");



        }
    }
}