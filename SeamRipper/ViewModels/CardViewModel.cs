using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeamRipper.Models
{
    public sealed class CardViewModel
    {
        public CardViewModel(Card card)
        {
            this.Name = card.Name;
            this.Effect = card.Effect;
            this.ImageLocation = "~/images/sun.svg";
        }

        public string Name
        {
            get;
            set;
        }

        public string Effect
        {
            get;
            set;
        }

        public string ImageLocation
        {
            get;
            set;
        }
    }
}
