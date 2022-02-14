using System;
using System.Collections.Generic;

namespace Cards
{
    public class Deck
    {
        public string[] Value = new string[]
        {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};

        public string[] Suit = new string[]
        {"Club","Spade","Hearts","Diamonds"};
        List<Card> makeDeck = new List<Card>();

        public Deck()
        // anytime you use the name of the class, it is a constructor
        {
            
            for(int i = 0; i < Value.Length; i++)
            {
                for(int j =0; j < Suit.Length; j++)
                {
                Card ourCard = new Card (Value[i], Suit[j], i + 1);
                // we have to declare the type of variable, which is Card in this situation
                makeDeck.Add(ourCard);
                }

            }

            foreach(Card card in makeDeck)
            {
                System.Console.WriteLine($"{card.suit} {card.value} {card.numvalue}");

            }
        }
        }
        }
