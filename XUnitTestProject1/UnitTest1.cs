using System;
using Xunit;
using Lab07_Collections.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// Add a card to the deck
        /// </summary>
        [Fact]
        public void AddACardToDeck()
        {
            Deck<Card> deck = new Deck<Card>();
            Card card = new Card();
            card.Suit = CardSuit.Diamonds;
            card.Value = Value.Nine;
            deck.Add(card);
            Assert.Equal(card, deck.cards[0]);
        }

        /// <summary>
        /// Removes a card from the deck 
        /// </summary>
        [Fact]
        public void RemoveACardFromDeckThatExists()
        {
            Deck<Card> deck = new Deck<Card>();
            Card card = new Card();
            card.Suit = CardSuit.Diamonds;
            card.Value = Value.Nine;
            deck.Add(card);
            deck.Remove();
            Assert.Equal(0, deck.count);
        }
    }
}
