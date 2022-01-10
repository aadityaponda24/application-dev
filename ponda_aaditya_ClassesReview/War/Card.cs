/*
 * Name : Aaditya Ponda
 * Date : 08 Jan 2022
 */

using System;
namespace War
{
    public class Card
    {
        // Create a private field for the card's suit (This should be an integer)
        // It will eventually store a number from 0 to 3
        private int _suit;

        // Create a public property for the value of the card. This will hold a
        // number from 1 to 13
        public int Value { get; }

        // Create a constructor that accepts suit and value in parameters and
        // sets the value and suit classmember variables accordingly
        public Card(int suit, int value)
        {
            this._suit = suit;
            this.Value = value;
        }

        //Create a method to display the value of the card. This should return a string.
            // Assume a suit of 0 is Spades, 1 is Hearts, 2 is Diammonds & 3 is Clubs
            // If the card value is 12 and suit is 0 the card
            // then this method should return "The Queen of Spades"
         public String DisplayCard()
        {
            return $"The {SuitString(this._suit)} of {ValueString(this.Value)}";
        }

        public String SuitString(int suit)
        {
            string suitString = "";
            switch(suit)
            {
                case 0: suitString = "Spades"; break;
                case 1: suitString = "Hearts"; break;
                case 2: suitString = "Diamonds"; break;
                case 3: suitString = "Clubs"; break;
            }
            return suitString;
        }

        public String ValueString(int value)
        {
            string valueString = "";
            switch (value)
            {
                case 1: valueString = "Ace"; break;
                case 2: valueString = "Two"; break;
                case 3: valueString = "Three"; break;
                case 4: valueString = "Four"; break;
                case 5: valueString = "Five"; break;
                case 6: valueString = "Six"; break;
                case 7: valueString = "Seven"; break;
                case 8: valueString = "Eight"; break;
                case 9: valueString = "Nine"; break;
                case 10: valueString = "Ten"; break;
                case 11: valueString = "Jack"; break;
                case 12: valueString = "Queen"; break;
                case 13: valueString = "King"; break;
            }
            return valueString;
        }
    }
}
