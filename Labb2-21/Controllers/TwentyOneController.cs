using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Labb2_21.Models;

namespace Labb2_21.Controllers
{
    public class TwentyOneController : Controller
    {
        // GET: TwentyOne
        public ActionResult Index()
        {
            var players = new List<Player>() { 
                
                new Player()
            {
                Name = "Stanislav Kolski",
                HairColor = "Gräddelin",
                Human = true,
            },
                new Player()
            {
                Name = "Bobolek Jetski",
                HairColor = "Gräddelin",
                Human = true,
            }};

            var twentyOne = new TwentyOne(players);

            this.Session["TwentyOneModel"] = twentyOne;

            return View("TwentyOne", twentyOne);
        }


        [HttpPost]
        public ActionResult Index(int button) // Variabel-namnet "button" är samma som name-propertyn på knappen i cshtml-filen. Båda knapparna heter samma sak, men det är den som blir klickad som är relevant (på denna raden).
        {
            var twentyOne = (TwentyOne)this.Session["TwentyOneModel"];

            //twentyOne.Sum += button.Value;

            //var random = new Random();

            //twentyOne.ActivePlayer = twentyOne.Players[random.Next(0,2)];

            //var announceWinner = twentyOne.Sum >= 21;

            //if (announceWinner)
            if (!twentyOne.GameOn(button))
            {
                return View("WinnerScreen", twentyOne.ActivePlayer);
            }

            return View("TwentyOne", twentyOne);
        }
    }
}