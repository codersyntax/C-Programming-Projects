using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsAI
{
    class Program
    {
        public static string Indent(int count)
        {
            return "".PadLeft(count);
        }

        public static void Intro()
        {
            Console.WriteLine("********************************************************************");
            Console.WriteLine("**                                                                **");
            Console.WriteLine("**              Let's Play Rock, Paper, Scissors!                 **");
            Console.WriteLine("**               Press any key to start new game.                 **");
            Console.WriteLine("**                                                                **");
            Console.WriteLine("********************************************************************");
            Console.ReadKey();
            Console.Clear();
        }

        public static void PlayGame()
        {
            Console.WriteLine("");
            Console.WriteLine(Indent(8) + "Player One!");
            Console.Write(Indent(8) + "Please choose: Rock (r), Paper (p), or Scissors (s) or Teresa Carter (t)? ");
            string playerOne = Console.ReadLine();
            Console.Clear();

            string[] AIOptions = { "p", "r", "s", "t"};

            string playerTwo = AIOptions[new Random().Next(0, AIOptions.Length)];
            Console.WriteLine("");
            Console.WriteLine(Indent(8) + "You chose: " + playerOne);
            Console.WriteLine(Indent(8) + "Computer chose: " + playerTwo);
            Console.WriteLine("");

            if (playerOne == "r" && playerTwo == "s")
            {
                Console.WriteLine(Indent(8) + "Rock beats Scissors! Player Wins!");
            }
            if (playerOne == "s" && playerTwo == "p")
            {
                Console.WriteLine(Indent(8) + "Scissors beats Paper! Player Wins!");
            }
            if (playerOne == "p" && playerTwo == "r")
            {
                Console.WriteLine(Indent(8) + "Paper beats Rock! Player Wins!");
            }
            if (playerOne == "t")
            {
                Console.WriteLine(Indent(8) + "Teresa Carter always wins!");
            }
            if (playerTwo == "r" && playerOne == "s")
            {
                Console.WriteLine(Indent(8) + "Rock beats Scissors! Computer Wins!");
            }
            if (playerTwo == "s" && playerOne == "p")
            {
                Console.WriteLine(Indent(8) + "Scissors beats Paper! Computer Wins!");
            }
            if (playerTwo == "p" && playerOne == "r")
            {
                Console.WriteLine(Indent(8) + "Paper beats Rock! Computer Wins!");
            }
            if (playerTwo == "t")
            {
                Console.WriteLine(Indent(8) + "Teresa Carter always wins!");
            }
            if (playerOne == playerTwo)
            {
                Console.WriteLine(Indent(8) + "Stalemate... You both suck....");
            }
            Console.WriteLine("");
            Console.WriteLine(Indent(8) + "Play another game? Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            PlayGame();
        }

        static void Main(string[] args)
        {
            Intro();
            PlayGame();
        }
    }
}
