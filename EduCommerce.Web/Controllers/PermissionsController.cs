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
            return View();
        }
       public ActionResult GetPermissions()
        {
            return View();
        }
        public ActionResult ListPermission()
        {
            List<Permissions> izinler = (from p in islemler.Permissions
                                         select p).ToList();

            return View(izinler);

        }
    }
}