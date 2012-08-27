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
            entry.Name
        }

    }
}
