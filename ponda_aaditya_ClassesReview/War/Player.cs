/*
 * Name : Aaditya Ponda
 * Date : 08 Jan 2022
 */
using System;
using System.Collections.Generic;

namespace War
{
    public class Player
    {
        // Create a List that will hold the player's hand of cards.
        // This should be a list of card objects.
        public List<Card> Hand {
            get; set; }

        // Create a property to store the player's name
        public string Name { get; }
        // Create a property to store the player's score
        public int Score { get; set; }

        // Create a constructor method that accepts the name
        // and stores the name in the Name Property
        public Player(string name)
        {
            this.Name = name;
            this.Score = 0;
            this.Hand = new List<Card>();
        }
    }
}
