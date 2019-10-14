using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameNameSpace
{

    public class DrawCard : MonoBehaviour
    {
        private static GameObject obj;

        public static void DrawCardsSuitValue(Card card)
        {
            switch(card.MySuit)
            {
                case Card.SUIT.Hearts:
                    Debug.Log("Hearts");
                    break;

                case Card.SUIT.Diamonds:
                    Debug.Log("Diamonds");
                    break;

                case Card.SUIT.Clubs:
                    Debug.Log("Clubs");
                    break;

                case Card.SUIT.Spades:
                    Debug.Log("Spades");
                    break;
            }
        }

        private void Start()
        {
            obj = new GameObject();
            obj.GetComponent<DealCards>().Deal();
        }

    }

}
