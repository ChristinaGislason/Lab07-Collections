using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections.Classes
{
    //'IEnumerable' is an adjective; T represents a generic type
    class Deck<T>: IEnumerable 
    {
        // Size allocation of cards array
        T[] cards = new T[5];
        int count = 0;

        /// <summary>
        /// Adds a card to the cards array
        /// </summary>
        /// <param name="card"></param>
        public void Add(T card)
        {
            if (count == cards.Length)
            {
                // Use array method to resize the length of array  
                Array.Resize(ref cards, cards.Length * 2);
            }
            cards[count++] = card;
        }

        /// <summary>
        /// Removes the last card added to a deck
        /// </summary>
        public void Remove()
        {
            Array.Resize(ref cards, cards.Length - 1);
            count--;
        }

        /// <summary>
        /// Returns all cards with a particular suit in the deck 
        /// </summary>
        /// <param name="suit"></param>
        /// <returns></returns>
        public Deck<T> ReturnSuit(CardSuit suit)
        {
            Deck<T> suitDeck = new Deck<T>();

            for (int i = 0; i < count; i++)
            {
                T item = cards[i];
                // cast item as a Card type
                if ((item as Card).Suit == suit)
                {
                    suitDeck.Add(item);
                }        
            }
            return suitDeck;
        }
        

        // Must ALWAYS do this in order to implement the IEnumberable interface 
        public IEnumerator<T> GetEnumerator()
        {
            // Underlying loop that will allow your foreach loop to run
            for (int i = 0; i < count; i++)
            {
                yield return cards[i];
            }
        }

        // Required to allow enumeration with legacy code
        // This is not a generic, we are using it to call the version that is a generic (above)
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
