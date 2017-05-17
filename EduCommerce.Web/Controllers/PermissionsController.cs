using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EduCommerce.Web.Controllers
{
    public class PermissionsController : Controller
    {
        KariyerPoliklinikDBEntities islemler = new KariyerPoliklinikDBEntities();
        // GET: Permissions
        public ActionResult Index()
        {
            return RedirectToAction("ListPermission");
        }
      
        public ActionResult ListPermission()
        {
            List<Permissions> izinler = (from p in islemler.Permissions
                                         select p).ToList();

            return View(izinler);

        }
        public ActionResult Yeni()
        {


            return View();
        }
        public ActionResult Detay(int id)
        {
            Permissions edu = (from p in islemler.Permissions
                              where p.ID == id
                              select p).FirstOrDefault();
            ViewBag.ID = 1;
            return View(edu);
        }
        [HttpPost]
        public ActionResult Yeni(Permissions yetkiler)
        {
            islemler.Permissions.Add(yetkiler);
            islemler.SaveChanges();

           return RedirectToAction("ListPermission");
            
        }

        public ActionResult Guncelle(int id)
        {
            ViewBag.Id = 1;
            Permissions yetkiler = (from p in islemler.Permissions
                                    where p.ID == id
                                    select p).FirstOrDefault();
            return View(yetkiler);
        }
        [HttpPost]
        public ActionResult Guncelle(Permissions yetkiler)
        {
            Permissions seciliYetki = (from p in islemler.Permissions
                                       where p.ID == yetkiler.ID
                                       select p).FirstOrDefault();
            seciliYetki.Code = yetkiler.Code;
            seciliYetki.Dealer = yetkiler.Dealer;
            seciliYetki.Name= yetkiler.Name;
            islemler.SaveChanges();
            return RedirectToAction("ListPermission");


        }
        public ActionResult Sil(int id)
        {
            Permissions yetkiler = (from p in islemler.Permissions
                                    where p.ID == id
                                    select p).FirstOrDefault();
            return View(yetkiler);
        }
        [HttpPost, ActionName("Sil")]
        public ActionResult SilmeIslemi(int id)
        {
            Permissions silinecekYetki = (from p in islemler.Permissions
                                          where p.ID == id
                                          select p).FirstOrDefault();

            int egitimId = silinecekYetki.ID;
            islemler.Permissions.Remove(silinecekYetki);
            islemler.SaveChanges();
            return RedirectToAction("ListPermissions");



        }
    }
}