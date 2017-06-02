using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EduCommerce.Web.Areas.Web.Controllers
{
    public class WebController : Controller
    {
        // GET: Web/Web
        public ActionResult Index()
        {
            return View();
        }
    }
}