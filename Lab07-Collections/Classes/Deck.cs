using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections.Classes
{
    //'IEnumerable' is an adjective; T represents a generic type
    class Deck<T>: IEnumerable 
    {
        // no industry standard for size here
        // this is the minimum size allocation
        T[] cards = new T[5];
        int count = 0;

        public void Add(T card)
        {
            if (count == cards.Length)
            {
                // array methods are fine to use now 
                // Resize() is not magic; it is an array under the hood, doing normal array things
                Array.Resize(ref cards, cards.Length * 2);
            }
            // count++ will only increase count *after* the action has been taken. ++count would do it before
            cards[count++] = card;
        }

        /// <summary>
        /// removes the last card added to a deck
        /// </summary>
        public void Remove()
        {
            Array.Resize(ref cards, cards.Length - 1);
        }

        
        public Deck<T> ReturnSuit(CardSuit Suit)
        {
            Deck<T> myCards = new Deck<T>();

            foreach (T item in cards)
            {
                // cast item as a Card type
                if ((item as Card).Suit == Suit)
                {
                    myCards.Add(item);
                }
            }
            return myCards;
        }
        

        //must ALWAYS do this in order to implement the IEnumberable interface 
        public IEnumerator<T> GetEnumerator()
        {
            // this is the underlying loop that will allow your foreach loop to run
            for (int i = 0; i < count; i++)
            {
                yield return cards[i];
            }
        }

        // this is required to allow enumeration with legacy code
        // this is not a generic, we are using it to call the version that is a generic (above)
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
