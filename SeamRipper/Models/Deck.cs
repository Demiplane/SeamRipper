using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeamRipper.Models
{
    public class Deck
    {
        public static Deck CreateLimitedDeck()
        {
            var deck = new Deck();
            deck.Cards = new List<Card>()
            {
                Card.Euryale,
                Card.Flames,
                Card.Jester,
                Card.Key,
                Card.Knight,
                Card.Moon,
                Card.Rogue,
                Card.Ruin,
                Card.Skull,
                Card.Star,
                Card.Sun,
                Card.Throne,
                Card.Void,
            };
            return deck;
        }

        public static Deck CreateFullDeck()
        {
            var deck = new Deck();
            deck.Cards = new List<Card>()
            {
                Card.Balance,
                Card.Comet,
                Card.Donjon,
                Card.Euryale,
                Card.Fates,
                Card.Flames,
                Card.Fool,
                Card.Gem,
                Card.Idiot,
                Card.Jester,
                Card.Key,
                Card.Knight,
                Card.Moon,
                Card.Rogue,
                Card.Ruin,
                Card.Skull,
                Card.Star,
                Card.Sun,
                Card.Talons,
                Card.Throne,
                Card.Vizier,
                Card.Void,
            };
            return deck;
        }

        public IEnumerable<Card> Cards
        {
            get;
            set;
        }
    }
}
