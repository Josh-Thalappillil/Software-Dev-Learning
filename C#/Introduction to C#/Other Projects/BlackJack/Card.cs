﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Card
    {
        public Suit suit { get; }
        public Rank rank { get; }
        public int Value { get; }

        public Card(Suit suitvalue, Rank rankvalue)
        {
            suit = suitvalue;
            rank = rankvalue;
            Value = (int)rankvalue;
        }
        public enum Suit
        {
            CLUB,
            DIAMOND,
            HEART,
            SPADE
        }
        public enum Rank
        {
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Jack = 10,
            Queen = 10,
            King = 10,
            Ace = 11
        }   
    }

}