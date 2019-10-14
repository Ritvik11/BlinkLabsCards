using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameNameSpace
{

    public class DealCards : MonoBehaviour
    {
        DeckOfCards DeckOfCards;
        private Card[] playerhand;
        private static GameObject obj;
       
        public int number_of_players;


        public DealCards()
        {
            playerhand = new Card[2];
          
        }

        public void Deal()
        {
            obj = new GameObject();
            obj.GetComponent<DeckOfCards>().setUpDeck();
            
        }
        public void getHand()
        {
            //2 cards for each player
            for (int i = 0; i < number_of_players; i++)
                for (int j = 0; j < 2; j++)
                    playerhand[i] = DeckOfCards.getDeck[i];
        }

        public void DisplayCards()
        {
         //   Debug.ClearDeveloperConsole();

            //Display Player Hand
            for (int i = 0; i < number_of_players; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    DrawCard.DrawCardsSuitValue(playerhand[j]);
                    Debug.Log("Player" + i + "Hand");
                    Debug.Log("Card" + j + playerhand[j]);
                }
            }
        }

    }
}
