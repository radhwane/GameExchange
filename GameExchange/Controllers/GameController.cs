using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameExchange.Models;

namespace GameExchange.Controllers
{
    public class GameController : Controller
    {
        // create a model object
        private GameContext entry_Game = new GameContext();

        //
        // GET: /Game/

        public ActionResult Index()
        {
            return View();
        }


        // Create a new Game or insert a new game into the
        // Database
        [HttpPost]
        public ActionResult Create(Game entry)
        {
            try
            {
                entry_Game.Entries.Add(entry);
                entry_Game.SaveChanges();

                return Content("A new game has been successfully added!");
            }
            catch (InvalidOperationException e)
            {
                e.StackTrace.ToString();
            }

            return Content("Add new Game failed!");
        }

    }
}
