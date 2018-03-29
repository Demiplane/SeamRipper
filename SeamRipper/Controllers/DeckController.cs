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
            var deckViewModel = new DeckViewModel(Deck.CreateFullDeck());

            return View("DeckView", deckViewModel);
        }
    }
}