using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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

        [Route("/deck/declare/{drawCount}")]
        public IActionResult Declare(int drawCount)
        {
            return new JsonResult(JsonConvert.SerializeObject(drawCount));
        }

        [Route("/deck/draw/{drawCount}")]
        public IActionResult Draw(int drawCount)
        {
            return new JsonResult(JsonConvert.SerializeObject(drawCount));
        }

        public IActionResult FreeDraw()
        {
            return Ok();
        }
    }
}