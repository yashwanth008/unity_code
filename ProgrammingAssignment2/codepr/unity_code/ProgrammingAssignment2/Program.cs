using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

namespace ProgrammingAssignment2
{
    // IMPORTANT: Only add code in the section
    // indicated below. The code I've provided
    // makes your solution work with the 
    // automated grader on Coursera

    /// <summary>
    /// Programming Assignment 2
    /// </summary>
    class Program
    {
        /// <summary>
        /// Implements Nothing Like Blackjack functionality
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {

                // Add your code between this comment
                // and the comment below. You can of
                // course add more space between the
                // comments as needed

                // declare a deck variables and create a deck object
                // DON'T SHUFFLE THE DECK
                deck deck= new deck();

                // deal 2 cards each to 4 players (deal properly, dealing
                // the first card to each player before dealing the
                // second card to each player)
                card card1player1=deck.taketopcard();
                card card1player2=deck.taketopcard();
                card card1player3=deck.taketopcard();
                card card1player4=deck.taketopcard();
                card card2player1=deck.taketopcard();
                card card2player2=deck.taketopcard();
                card card2player3=deck.taketopcard();
                card card2player4=deck.taketopcard();
               

                // deal 1 more card to players 2 and 3
                card card3player2=deck.taketopcard();
                card card3player3=deck.taketopcard();

                // flip all the cards over
                card1player1.FlipOver();
                card1player2.FlipOver();
                card1player3.FlipOver();
                card1player4.FlipOver();
                card2player1.FlipOver();
                card2player2.FlipOver();
                card2player3.FlipOver();
                card2player4.FlipOver();
                card3player2.FlipOver();
                card3player3.FlipOver();

                // print the cards for player 1
                Console.WriteLine(card1player1.Rank + "of" + card1player1.suit);
                Console.WriteLine(card2player1.Rank + "of" + card2player1.suit);
                // print the cards for player 2
                Console.WriteLine(card1player2.Rank + "of" + card1player2.suit);
                Console.WriteLine(card2player2.Rank + "of" + card2player2.suit);
                Console.WriteLine(card3player2.Rank + "of" + card3player2.suit);
                // print the cards for player 3
                Console.WriteLine(card1player3.Rank + "of" + card1player3.suit);
                Console.WriteLine(card2player3.Rank + "of" + card2player3.suit);
                Console.WriteLine(card3player3.Rank + "of" + card3player3.suit);
                // print the cards for player 4
                Console.WriteLine(card1player4.Rank + "of" + card1player4.suit);
                Console.WriteLine(card2player4.Rank + "of" + card2player4.suit);
                // Don't add or modify any code below
                // this comment
                input = Console.ReadLine();
            }
        }
    }
}
