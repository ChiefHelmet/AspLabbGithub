using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab21.Controllers
{
    public class GameController : Controller
    {
        Models.Game model = new Models.Game();

        // GET: Game
        public ActionResult Index()
        {
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(string player, string number, string oldNum)
        {
            model.number = int.Parse(oldNum);
            model.SetNumber(int.Parse(number));
            return View(model);
        }
    }
}