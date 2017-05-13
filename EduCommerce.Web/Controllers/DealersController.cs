using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EduCommerce.Core;
using System.Data;
using System.Data.Entity;

namespace EduCommerce.Web.Controllers
{
    public class DealersController : Controller
    {
        KariyerPoliklinikDBEntities islemler = new KariyerPoliklinikDBEntities();
        
        // GET: Dealers
        public ActionResult Index()
        {
            return View();
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
        
        public ActionResult InsertDealers()
        {
            return View();

        }
       

    }
}