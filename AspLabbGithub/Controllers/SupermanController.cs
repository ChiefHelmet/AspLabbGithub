using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspLabbGithub.Controllers
{
    public class SupermanController : Controller
    {
        // GET: Superman
        public ActionResult DoGood()
        {
            return View();
        }
    }
}