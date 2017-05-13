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
            StudentCore sCore = new StudentCore();
            DataTable model = sCore.getAll();
            return View(model);
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
    }
}