using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Labb2TicTacToe.Models;
using Labb2_21.Models;

namespace Labb2TicTacToe.Controllers
{
    public class TicTacToeController : Controller
    {
        // GET: TicTacToe
        public ActionResult Index() //Get
        {
            var players = new List<Player>()
            {
                new Player()
                {
                    Human = true,
                    Name = "Dahpni Hoffipoff",
                    Symbol = 'X',
                },
                new Player()
                {
                    Human = true,
                    Name = "Knut Kragballe",
                    Symbol = 'Q',
                }
            };

            var ticTacToeModel = new TicTacToe(players);

            this.Session["TicTacToeModel"] = ticTacToeModel;  //tar objektet ticTacTacmodel och stoppar in i session med nyckeln "tictactoemodel"
            return View("TicTacToe", ticTacToeModel);
        }

        [HttpPost]  //Post
        public ActionResult Index(int button)  //variabelnamnet button mappar mot knappen med samma attribut name="button"
        {
            ViewBag.Kristian = button;

            var ticTacToeModel = (TicTacToe)this.Session["TicTacToeModel"]; // Det inom paranteser är för att specificera att det returnerande objektet ÄR ticTacToe och inte ett generiskt objekt

            //ticTacToeModel.Moves.Add(new Move('X', button));  //Nu har vi registrerat vårt nya "move" 

            bool gameOn = ticTacToeModel.GameOn(button);

            if (!gameOn && ticTacToeModel.Tie)
            {
                return View("TicTacTie", ticTacToeModel);
            }
            if (!gameOn)
            {
                return View("TicTacWin", ticTacToeModel.ActivePlayer);
            }
            


            return View("TicTacToe", ticTacToeModel);  //Måste alltid speca vilken modell som skall med 
        }
    }
}