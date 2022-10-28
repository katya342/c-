using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Player
    {
        public string Name { get; set; }
        public int Scores { get; set; }
        public List<Card> CardDeck = new List<Card>();
    }
}
