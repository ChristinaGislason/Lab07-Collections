using Lab07_Collections.Classes;
using System;
using System.Collections.Generic;

namespace Lab07_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericCollection();
        }

        static void GenericCollection()
        {
            // Instantiate collection
            // Instantiate ten cards with values
            Deck<Card> myCards = new Deck<Card>()
            {
                new Card { Suit = CardSuit.Spades, Value = Value.Ace },
                new Card { Suit = CardSuit.Hearts, Value = Value.Eight },
                new Card { Suit = CardSuit.Diamonds, Value = Value.Two },
                new Card { Suit = CardSuit.Hearts, Value = Value.King },
                new Card { Suit = CardSuit.Clubs, Value = Value.Queen },
                new Card { Suit = CardSuit.Spades, Value = Value.Four },
                new Card { Suit = CardSuit.Spades, Value = Value.Five },
                new Card { Suit = CardSuit.Hearts, Value = Value.Six },
                new Card { Suit = CardSuit.Clubs, Value = Value.Ace },
                new Card { Suit = CardSuit.Spades, Value = Value.Jack }
            };

            Console.WriteLine("Add ten cards to the deck:");
            // Prints out the deck to the console
            foreach (Card card in myCards)
            {
                Console.WriteLine($"Suit: {card.Suit}, Value: {card.Value}");
            }

            Console.WriteLine("----------");
            Console.WriteLine("Add a card to the deck:");
            // Adds a new card to the deck 
            Card card1 = new Card();
            card1.Suit = CardSuit.Diamonds;
            card1.Value = Value.Nine;
            myCards.Add(card1);
            Console.WriteLine($"Suit: {card1.Suit}, Value: {card1.Value}");

            // Print out the deck, including the newly added card, to the console
            foreach (Card card in myCards)
            {
                Console.WriteLine($"Suit: {card.Suit}, Value: {card.Value}");
            }

            Console.WriteLine("----------");
            // Removes the last card added to the deck and prints it out on console
            Console.WriteLine("Remove last card added to the deck:");
            myCards.Remove();
            foreach (Card card in myCards)
            {
                Console.WriteLine($"Suit: {card.Suit}, Value: {card.Value}");
            }

            Console.WriteLine("----------");
            // Returns a particular suit and prints out the updated deck to console
            Console.WriteLine("Return all cards with Suit of Clubs:");
            Deck<Card> clubs = myCards.ReturnSuit(CardSuit.Clubs);
            foreach (Card card in clubs)
            {
                Console.WriteLine($"Suit: {card.Suit}, Value: {card.Value}");
            }
        }
    }
}
