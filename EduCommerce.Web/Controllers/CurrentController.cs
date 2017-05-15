using EduCommerce.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace EduCommerce.Web.Controllers
{
    public class CurrentController : Controller
    {
        KariyerPoliklinikDBEntities islemler = new KariyerPoliklinikDBEntities();
        // GET: Current
        public ActionResult Index()
        {
            return RedirectToAction("ListCurrent");
        }
        public ActionResult ListCurrent()
        { 
            List<Current> Hesap = (from p in islemler.Current
                                   select p).ToList();
            
            return View(Hesap);
        }

        public ActionResult GetCurrent()
        {
            CurrentCore cCore = new CurrentCore();
            DataTable model = cCore.getAll();

            return View(model);
        }
        public ActionResult PartCurrent()
        {
            CurrentCore cCore = new CurrentCore();
            DataTable model = cCore.getAll();

            return PartialView(model);;
            


        }
        public ActionResult Detay(int id)
        {
            Current edu = (from p in islemler.Current
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
        public ActionResult Yeni(Current cari)
        {
            islemler.Current.Add(cari);
            islemler.SaveChanges();

            RedirectToAction("ListCurrent");
            return View();

        }

        public ActionResult Guncelle(int id)
        {
            ViewBag.Id = 1;
            Current cari = (from p in islemler.Current
                                    where p.ID == id
                                    select p).FirstOrDefault();
            return View(cari);
        }
        [HttpPost]
        public ActionResult Guncelle(Current cari)
        {
            Current seciliCari = (from p in islemler.Current
                                    where p.ID == cari.ID
                                    select p).FirstOrDefault();
            seciliCari.DealerID = cari.DealerID;
            seciliCari.Class = cari.Class;
            seciliCari.Quantity = cari.Quantity;
            seciliCari.Status = cari.Status;
            seciliCari.Type = cari.Type;
            seciliCari.StudentID = cari.StudentID;
            islemler.SaveChanges();
            return View();


        }
        public ActionResult Sil(int id)
        {
            Current cari = (from p in islemler.Current
                                    where p.ID == id
                                    select p).FirstOrDefault();
            return View(cari);
        }
        [HttpPost, ActionName("Sil")]
        public ActionResult SilmeIslemi(int id)
        {
            Current silinecekCari = (from p in islemler.Current
                                          where p.ID == id
                                          select p).FirstOrDefault();

            int egitimId = silinecekCari.ID;
            islemler.Current.Remove(silinecekCari);
            islemler.SaveChanges();
            return RedirectToAction("ListCurrent");



        }


    }
}