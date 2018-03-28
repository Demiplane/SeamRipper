using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeamRipper.Models;

namespace SeamRipper.Controllers
{
    public class DeckController : Controller
    {
        public IActionResult List()
        {
            var deckViewModel = new DeckViewModel();

            deckViewModel.CardNames = new List<String>() { "Knight", "Sun", "Moon", "Void", };

            return View("DeckView", deckViewModel);
        }
    }
}