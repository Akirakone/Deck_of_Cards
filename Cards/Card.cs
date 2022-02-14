using System;
using System.Collections.Generic;

namespace Cards
{
    public class Card
    {
        public string value;
        public string suit;
        public int numvalue;

        public Card(string val, string st, int num)
        {
            value = val;
            suit = st;
            numvalue = num;
        }
}
 }