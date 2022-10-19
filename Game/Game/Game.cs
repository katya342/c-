using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Game
    {
        public List<Card> GetCardDeck()
        {
            Random random = new Random();
            List<Card> CardDeck = new List<Card>();
            foreach (var item in (Suit[])Enum.GetValues(typeof(Suit)))
            {
                for (int i = 6; i < 15; i++)
                {
                    Card card = new Card();
                    card.Number = i;
                    card.CardSuit = item;
                    card.IsTrump = false;
                    CardDeck.Add(card);
                }
            }
            return CardDeck;
        }
        public void Distribution(List<Player>players)
        {
            List<Card> CardDeck = GetCardDeck();
            int count = players.Count;
            int i = 0;
            foreach (var item in CardDeck)
            {
                players[i].CardDeck.Add(item);
                if (i <= count)
                    i++;
                else
                    i = 0;
                
            }
        }
    }
}
