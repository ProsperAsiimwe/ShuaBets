using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShuaBets.WebUI.Controllers
{
    public class HomeAdminController : BaseController
    {
        // GET: HomeAdmin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PublicPage()
        {

            return RedirectToAction("Index", "Home");
        }

    }
}