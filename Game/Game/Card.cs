using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    // масть карты, номер карты, 
    public enum Suit { Piki, Bubi, Chervi, Kresti}
    public class Card
    {
       // public Suit Suit { get; set; }
        public Suit CardSuit { get; set; }
        public bool IsTrump { get; set; }
        public int Number { get; set; }

    }
}
