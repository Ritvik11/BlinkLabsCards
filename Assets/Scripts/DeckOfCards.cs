
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameNameSpace
{

    public class DeckOfCards : MonoBehaviour
    {
        const int NUM_OF_CARDS = 52; //number of all cards
        private Card[] deck; //array of all playing cards

        public DeckOfCards()
        {
            deck = new Card[NUM_OF_CARDS];
        }

        public Card[] getDeck { get { return deck; } } //get current deck

        //create deck of 52 cards: 13 Values each, with 4 suits
        public void setUpDeck()
        {
            int i = 0;
            foreach (Card.SUIT s in System.Enum.GetValues(typeof(Card.SUIT)))
            {
                foreach (Card.VALUE v in System.Enum.GetValues(typeof(Card.VALUE)))
                {
                    deck[i] = new Card { MySuit = s, MyValue = v,  };
                    i++;
                }
            }

            ShuffleCards();
        }

        //shuffle the deck
        public void ShuffleCards()
        {
            
            Card temp;

            //run the shuffle 1000 times
            for (int shuffleTimes = 0; shuffleTimes < 1000; shuffleTimes++)
            {
                for (int i = 0; i < NUM_OF_CARDS; i++)
                {
                    //swap the cards
                    int secondCardIndex = Random.Range(1,13);
                    temp = deck[i];
                    deck[i] = deck[secondCardIndex];
                    deck[secondCardIndex] = temp;
                }
            }
        }
    }
}


