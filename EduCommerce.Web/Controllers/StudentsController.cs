using EduCommerce.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EduCommerce.Web.Controllers
{
    public class StudentsController : Controller
    {
        KariyerPoliklinikDBEntities islemler = new KariyerPoliklinikDBEntities();
        // GET: Students
        public ActionResult Index()
        {
            return RedirectToAction("ListStudents");
        }
        public ActionResult  GetStudents()
        {
            StudentCore sCore = new StudentCore();
            DataTable model = sCore.getAll();
            return View(model);
        }
        public ActionResult ListStudents()
        {
            List<Students> ogrenciler = (from p in islemler.Students
                                         select p).ToList();

            return View(ogrenciler);
        }
        public ActionResult Detay(int id)
        {
            Students edu = (from p in islemler.Students
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
        public ActionResult Yeni(Students ogrenciler)
        {
            islemler.Students.Add(ogrenciler);
            islemler.SaveChanges();

            RedirectToAction("ListStudents");
            return View();

        }

        public ActionResult Guncelle(int id)
        {
            ViewBag.Id = 1;
            Students ogrenciler = (from p in islemler.Students
                                    where p.ID == id
                                    select p).FirstOrDefault();
            return View(ogrenciler);
        }
        [HttpPost]
        public ActionResult Guncelle(Students ogrenciler)
        {
            Students seciliOgrenci = (from p in islemler.Students
                                       where p.ID == ogrenciler.ID
                                       select p).FirstOrDefault();
            seciliOgrenci.Adress = ogrenciler.Adress;
            seciliOgrenci.BornDate = ogrenciler.BornDate;
            seciliOgrenci.DealerID = ogrenciler.DealerID;
         


            seciliOgrenci.Document = ogrenciler.Document;
            seciliOgrenci.EDate = ogrenciler.EDate;
            seciliOgrenci.EduStatus = ogrenciler.EduStatus;
            seciliOgrenci.Email = ogrenciler.Email;

            seciliOgrenci.EduStatus = ogrenciler.EduStatus;
            seciliOgrenci.Email = ogrenciler.Email;
            seciliOgrenci.FinishDate = ogrenciler.FinishDate;
            seciliOgrenci.Gender = ogrenciler.Gender;

            seciliOgrenci.GKOD = ogrenciler.GKOD;
            seciliOgrenci.Language = ogrenciler.Language;
            seciliOgrenci.Phone = ogrenciler.Phone;
            seciliOgrenci.StartDate = ogrenciler.StartDate;


            seciliOgrenci.Status = ogrenciler.Status;
            seciliOgrenci.StudentLoginDate = ogrenciler.StudentLoginDate;
            seciliOgrenci.StudentLoginIP = ogrenciler.StudentLoginIP;
            seciliOgrenci.StudentName = ogrenciler.StudentName;

            seciliOgrenci.StudentPass = ogrenciler.StudentPass;
            seciliOgrenci.StudentUser = ogrenciler.StudentUser;
            seciliOgrenci.TCNumber = ogrenciler.TCNumber;

            islemler.SaveChanges();
            return View();


        }
        public ActionResult Sil(int id)
        {
            Students ogrenciler = (from p in islemler.Students
                                    where p.ID == id
                                    select p).FirstOrDefault();
            return View(ogrenciler);
        }
        [HttpPost, ActionName("Sil")]
        public ActionResult SilmeIslemi(int id)
        {
            Students silinecekOgrenci = (from p in islemler.Students
                                          where p.ID == id
                                          select p).FirstOrDefault();

            int egitimId = silinecekOgrenci.ID;
            islemler.Students.Remove(silinecekOgrenci);
            islemler.SaveChanges();
            return RedirectToAction("ListStudents");



        }
    }
}