// --------------------------------------------------------------------------------------------------------------------
// <copyright file=DeckOfCard.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Priyanand Pritam"/>
// --------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.DeckOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class DackofCard
    {
        private int[,] deckofcard = new int[4, 13];
        private Random random = new Random();
        private int player = 1;
        public static string Suit(int suit)
        {
            switch (suit)
            {
                case 0:
                    {
                        return "clubs";
                    }
                case 1:
                    {
                        return "Diamond";
                    }
                case 2:
                    {
                        return "Heart";
                    }
                case 3:
                    {
                        return "Spade";
                    }
                default:
                    {
                        return "in switch (default)";
                    }
            }
        }
        //
        public static string Rank(int Rank)
        {
            switch(Rank)
            {
                case 0:
                    {
                        return "2";
                    }
                case 1:
                    {
                        return "3";
                    }
                case 2:
                    {
                        return "4";
                    }
                case 3:
                    {
                        return "5";
                    }
                case 4:
                    {
                        return "6";
                    }
                case 5:
                    {
                        return "7";
                    }
                case 6:
                    {
                        return "8";
                    }
                case 7:
                    {
                        return "9";
                    }
                case 8:
                    {
                        return "10";
                    }
                case 9:
                    {
                        return "Jack";
                    }
                case 10:
                    {
                        return "Queen";
                    }
                case 11:
                    {
                        return "King";
                    }
                case 12:
                    {
                        return "Ace";
                    }
                default:
                    {
                        return string.Empty;
                    }
            }
        }
        public void InitializeDeckofCard()
        {
            for(int player = 1; player <= 4; player++ )
            {
                this.Distribute9card(player);
                Console.WriteLine("player" + this.player);
                this.player++;
                Console.WriteLine("...");
                this.Print(player);
                Console.WriteLine("....");
            }
        }
        public void Distribute9card(int player)
        {
            for(int i = 0; i<9; i++)
            {
                this.ShuffleCard(player);
            }
        }

        public void ShuffleCard(int player)
        {
            //generating a random number of suits.
            int suit = this.random.Next(1, 4);
            int Rank = this.random.Next(1, 13);
            if(this.deckofcard[suit, Rank] == 0)
            {
                this.deckofcard[suit, Rank] = player;
                return;
            }
            else
            {
                this.ShuffleCard(player);
            }
        }

        public void Print(int player)
        {
            int suitLength = this.deckofcard.GetLength(0);
            int RankLength = this.deckofcard.GetLength(1);
            for(int suit = 0; suit < suitLength;suit++)
            {
                for(int ranks = 0; ranks < RankLength;ranks++)
                {
                    if(this.deckofcard[suit,ranks] == player)
                    {
                        Console.WriteLine(Suit(suit) + " " + Rank(ranks));
                    }
                }
            }
        }

       
    }
}
