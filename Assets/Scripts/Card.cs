using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace GameNameSpace
{
    public class Card : MonoBehaviour
    {
        public Sprite card_sprite;

       public enum SUIT
        {
            Hearts,
            Spades,
            Diamonds,
            Clubs,
            
        }

        public enum VALUE
        {
            Two = 2, Three, Four, Five, Six, Seven,
            Eight, Nine, Ten, Jack, Queen, King, Ace
        }

        public SUIT MySuit { get; set; }
        public VALUE MyValue { get; set; }

       
    }

}