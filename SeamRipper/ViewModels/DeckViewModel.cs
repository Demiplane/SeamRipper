using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeamRipper.Models
{
    public class DeckViewModel
    {
        public DeckViewModel(Deck deck)
        {
            this.Cards = deck.Cards.Select(c => new CardViewModel(c)).ToList();
        }

        public IList<CardViewModel> DrawnCards
        {
            get;
            set;
        } = new List<CardViewModel>();

        public IEnumerable<CardViewModel> Cards
        {
            get;
            set;
        } = new List<CardViewModel>();
    }
}
