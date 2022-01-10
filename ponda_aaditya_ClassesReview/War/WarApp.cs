/*
 * Name : Aaditya Ponda
 * Date : 08 Jan 2022
 */
using System;
using System.Collections.Generic;

namespace War
{
    public class WarApp
    {
        //create a private list that holds your Players.
        private List<Player> _players = new List<Player>();

        public WarApp()
        {
            // Create a variable to store a deck and get the deck from the
            // DeckUtility class's CreateDeck method
            List<Card> deck = DeckUtility.CreateDeck();
            deck = DeckUtility.ShuffleDeck(deck);

            // Welcome the user
            // Ask the user for the name of player 1 and player 2. Be sure to validate.
            Console.WriteLine("Welcome to War!");
            Console.WriteLine();
            string player1Name = Validation.ValidateString("Who is player 1? ");
            Console.WriteLine();
            string player2Name = Validation.ValidateString("Who is player 2? ");
            Console.WriteLine();

            // Create two player objects using the info from the user and store
            // them in the players list you created earlier.
            // Give each player half of the deck using the DivideDeck method
            Player player1 = new Player(player1Name);
            Player player2 = new Player(player2Name);
            _players.Add(player1);
            _players.Add(player2);
            Dictionary<string, List<Card>> hands = DeckUtility.DivideDeck(deck);
            player1.Hand = hands["first_half"];
            player2.Hand = hands["second_half"];

            Play();
        }

        public void Play()
        {
            // Announce the two players by name
            Console.WriteLine($"We have got two players {_players[0].Name} and {_players[1].Name}");

            List<string> playAgainChoice = new List<string>();
            playAgainChoice.Add("y");
            playAgainChoice.Add("Y");
            playAgainChoice.Add("n");
            playAgainChoice.Add("N");

            // Ask the user if they would like to see a continue
            string playagain = Validation.ValidatInList("Shall we play a round of WAR? (y/n)", playAgainChoice);
            Console.WriteLine();

            // Loop as long as the users have cards in their hands and the user
            // answers "yes" to this question
            while(_players[0].Hand.Count > 0 && playagain.ToLower() == "y")
            {
                Round();
                if (_players[0].Hand.Count > 0)
                {
                    playagain = Validation.ValidatInList("Shall we play a round of WAR? (y/n)", playAgainChoice);
                    Console.WriteLine();
                }
            }

            // When this loop is over you should call the EndGame() method.
            EndGame();
        }
        public void Round()
        {
            // Draw a card from each player's hand. Be sure to remove it entirely.
            // Evaluate who won the round using the cards, adjust the score, and
            // display it using the DisplayScore method

            Card player1card = _players[0].Hand[0];
            Card player2card = _players[1].Hand[0];
            _players[0].Hand.RemoveAt(0);
            _players[1].Hand.RemoveAt(0);
            string winner = "";

            if(player1card.Value > player2card.Value)
            {
                _players[0].Score++;
                winner = _players[0].Name;
            }
            else if (player2card.Value > player1card.Value)
            {
                _players[1].Score++;
                winner = _players[1].Name;
            }

            Console.WriteLine($"{_players[0].Name} has {player1card.DisplayCard()}");
            Console.WriteLine($"{_players[1].Name} has {player2card.DisplayCard()}");
            if(winner == "")
            {
                Console.WriteLine("Tie");
            }
            else
            {
                Console.WriteLine(winner + " wins this round");
            }

            DisplayScore();

        }
        public void DisplayScore()
        {
            // Display each player's name and score and how many cards are left in
            // each player's hand
            Console.WriteLine();
            Console.WriteLine("********************************************");
            Console.WriteLine(_players[0].Name + ":" + _players[0].Score + "   " + _players[1].Name + ":" + _players[1].Score);
            Console.WriteLine("Each players has " + _players[0].Hand.Count + " cards left in their deck.");
            Console.WriteLine("********************************************");
            Console.WriteLine();
        }

        public void EndGame()
        {
            // Announce the end of the game
            // User the player's score to determine who has won the game
            // Announce the winner or if the game was a tie.
            Console.WriteLine("End of the game!");
            string winner = "";
            if(_players[0].Score > _players[1].Score)
            {
                Console.WriteLine(_players[0].Name + " wins the Game!!!");
            }
            else if (_players[1].Score > _players[0].Score)
            {
                Console.WriteLine(_players[1].Name + " wins the Game!!!");
            }
            else
            {
                Console.WriteLine("The game is a Tie!!!");
            }
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
