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
            return View();
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
        public ActionResult Yeni()
        {


        }
      
     
    }
}