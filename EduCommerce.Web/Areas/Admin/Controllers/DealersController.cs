using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EduCommerce.Core;
using System.Data;
using System.Data.Entity;

namespace EduCommerce.Web.Areas.Admin.Controllers
{
    public class DealersController : Controller
    {
        KariyerPoliklinikDBEntities islemler = new KariyerPoliklinikDBEntities();
        
        // GET: Dealers
        public ActionResult Index()
        {
            return RedirectToAction("ListDealers");
        }
        public ActionResult GetDealers()
        {
             DealersCore dCore = new DealersCore();
            DataTable model = dCore.getAll();
           return PartialView(model);
        }
        public ActionResult ListDealers()
        {
            List<Dealers> Bayiler = (from p in islemler.Dealers
                                     select p).ToList();
           
            return View(Bayiler);
        }

        public ActionResult Detay(int id)
        {
            Dealers edu = (from p in islemler.Dealers
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
        public ActionResult Yeni(Dealers bayiler)
        {
            islemler.Dealers.Add(bayiler);
            islemler.SaveChanges();

            RedirectToAction("ListEducation");
            return RedirectToAction("ListDealers");

        }

        public ActionResult Guncelle(int id)
        {
            ViewBag.Id = 1;
            Dealers bayiler = (from p in islemler.Dealers
                                    where p.ID == id
                                    select p).FirstOrDefault();
            return View(bayiler);
        }
        [HttpPost]
        public ActionResult Guncelle(Dealers bayiler)
        {
            Dealers seciliBayi = (from p in islemler.Dealers
                                       where p.ID == bayiler.ID
                                       select p).FirstOrDefault();
            seciliBayi.DealerName = bayiler.DealerName;
            seciliBayi.AccountName = bayiler.AccountName;
            seciliBayi.BankName = bayiler.BankName;
            seciliBayi.CityID = bayiler.CityID;
            seciliBayi.CountryID = bayiler.CountryID;
            seciliBayi.DealerAddress = bayiler.DealerAddress;
            seciliBayi.DealerLoginDate = bayiler.DealerLoginDate;
            seciliBayi.DealerLoginIP = bayiler.DealerLoginIP;
            seciliBayi.DealerMail = bayiler.DealerMail;
            seciliBayi.DealerPass = bayiler.DealerPass;
            seciliBayi.DealerPhone = bayiler.DealerPhone;
            seciliBayi.DealerPicture = bayiler.DealerPicture;

            seciliBayi.DealerType = bayiler.DealerType;
            seciliBayi.DealerUser = bayiler.DealerUser;
            seciliBayi.Domain = bayiler.Domain;
            seciliBayi.GKOD = bayiler.GKOD;

            seciliBayi.IBAN = bayiler.IBAN;
            seciliBayi.ID = bayiler.ID;
            seciliBayi.Logo = bayiler.Logo;
            seciliBayi.MailTo = bayiler.MailTo;

            seciliBayi.Percentage = bayiler.Percentage;
            seciliBayi.Permissions = bayiler.Permissions;
            seciliBayi.Status = bayiler.Status;
            seciliBayi.TaxNo = bayiler.TaxNo;
            seciliBayi.UpDealer = bayiler.UpDealer;
            seciliBayi.VLanguage = bayiler.VLanguage;
            seciliBayi.BankName = bayiler.BankName;
            seciliBayi.WebSite = bayiler.WebSite;

            islemler.SaveChanges();
            return RedirectToAction("ListDealers");



        }
        public ActionResult Sil(int id)
        {
            Dealers bayiler = (from p in islemler.Dealers
                                    where p.ID == id
                                    select p).FirstOrDefault();
            return View(bayiler);
        }
        [HttpPost, ActionName("Sil")]
        public ActionResult SilmeIslemi(int id)
        {
            Dealers silinecekEgitim = (from p in islemler.Dealers
                                          where p.ID == id
                                          select p).FirstOrDefault();

            int egitimId = silinecekEgitim.ID;
            islemler.Dealers.Remove(silinecekEgitim);
            islemler.SaveChanges();
            return RedirectToAction("ListDealers");

        }


    }
}