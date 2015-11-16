using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow_TheEndOfCardgame
{
    class deck
    {
        private Stack<card> card_deck;

        public deck(int num = 0)
        {
            card_deck = new Stack<card>(num);

            if(num==52) //maindeck
            {
                //(♥), diamonds(♦) and clubs (♣)
                card_deck.Push(new card(2, "2♠"));
                card_deck.Push(new card(2, "2♦"));
                card_deck.Push(new card(2, "2♣"));
                card_deck.Push(new card(2, "2♥"));

                card_deck.Push(new card(3, "3♠"));
                card_deck.Push(new card(3, "3♦"));
                card_deck.Push(new card(3, "3♣"));
                card_deck.Push(new card(3, "3♥"));

                card_deck.Push(new card(4, "4♠"));
                card_deck.Push(new card(4, "4♦"));
                card_deck.Push(new card(4, "4♣"));
                card_deck.Push(new card(4, "4♥"));

                card_deck.Push(new card(5, "5♠"));
                card_deck.Push(new card(5, "5♦"));
                card_deck.Push(new card(5, "5♣"));
                card_deck.Push(new card(5, "5♥"));

                card_deck.Push(new card(6, "6♠"));
                card_deck.Push(new card(6, "6♦"));
                card_deck.Push(new card(6, "6♣"));
                card_deck.Push(new card(6, "6♥"));

                card_deck.Push(new card(7, "7♠"));
                card_deck.Push(new card(7, "7♦"));
                card_deck.Push(new card(7, "7♣"));
                card_deck.Push(new card(7, "7♥"));

                card_deck.Push(new card(8, "8♠"));
                card_deck.Push(new card(8, "8♦"));
                card_deck.Push(new card(8, "8♣"));
                card_deck.Push(new card(8, "8♥"));

                card_deck.Push(new card(9, "9♠"));
                card_deck.Push(new card(9, "9♦"));
                card_deck.Push(new card(9, "9♣"));
                card_deck.Push(new card(9, "9♥"));

                card_deck.Push(new card(10, "10♠"));
                card_deck.Push(new card(10, "10♦"));
                card_deck.Push(new card(10, "10♣"));
                card_deck.Push(new card(10, "10♥"));

                card_deck.Push(new card(11, "Jack♠"));
                card_deck.Push(new card(11, "Jack♦"));
                card_deck.Push(new card(11, "Jack♣"));
                card_deck.Push(new card(11, "Jack♥"));

                card_deck.Push(new card(12, "Queen♠"));
                card_deck.Push(new card(12, "Queen♦"));
                card_deck.Push(new card(12, "Queen♣"));
                card_deck.Push(new card(12, "Queen♥"));

                card_deck.Push(new card(13, "King♠"));
                card_deck.Push(new card(13, "King♦"));
                card_deck.Push(new card(13, "King♣"));
                card_deck.Push(new card(13, "King♥"));

                card_deck.Push(new card(14, "Ace♠"));
                card_deck.Push(new card(14, "Ace♦"));
                card_deck.Push(new card(14, "Ace♣"));
                card_deck.Push(new card(14, "Ace♥"));
            }
        }

        public card drawcard()
        {
            return card_deck.Pop();
        }

        public void pushcard(card c)
        {
            card_deck.Push(c);
        }
        public int getnumcard()
        {
            return card_deck.Count;
        }

        public void shuffle()
        {
            Random r = new Random();
            for (int n = card_deck.Count - 1; n > 0; --n)
            {
                int k = r.Next(n + 1);
                card temp = card_deck.ElementAt(k);

                card_deck.ElementAt(n).switchcardval(card_deck.ElementAt(k));
                card_deck.ElementAt(k).switchcardval(temp);
            }
        }
    }
}
