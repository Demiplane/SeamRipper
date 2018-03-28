using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeamRipper.Models
{
    public class DeckViewModel
    {
        public IEnumerable<string> CardNames
        {
            get;
            set;
        } = new List<String>();
    }
}
