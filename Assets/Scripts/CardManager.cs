using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsManager : MonoBehaviour
{
    public static CardsManager instance = null;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }

    }


    public enum SuitEnum { Hearts = 1, Clubs = 2, Diamonds = 3, Spades = 4 }
    public enum ColorEnum { Red = 1, Black = 2 }

    public List<Card> CardDeck = new List<Card>();  // List of Ordered 52 Cards.
    public List<Card> CardList = new List<Card>();  // List of card(s) of specific player

    int NumberOfPlayers;     // No of people to assign 3 cards to them.
    int k;  // That will randomly fetch cards from database

    public class Card //Card class to use in lists as datatype.
    {
        public SuitEnum suit;
        public ColorEnum color;
        public int rank;
        public Sprite card_sprite;


        public Card(SuitEnum newsuit, int newrank, ColorEnum newcolor, Sprite newsprite)
        {
            suit = newsuit;
            rank = newrank;
            color = newcolor;
            card_sprite = newsprite;
        }
    }
}
