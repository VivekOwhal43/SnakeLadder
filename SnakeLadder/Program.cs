// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace SnakeLadder
{
    class Program
    {
        public static int totalBoardNumber = 100;
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Snake Ladder Game\n");
            Console.WriteLine("Let's Play\n");

            TwoPlayers player1 = new TwoPlayers(1);
            TwoPlayers player2 = new TwoPlayers(2);

            while (true)
            {
                Console.WriteLine("\n\nPlayer 1 turn's....");
                player1.DiceRolls();
                player1.Move();
                if (player1.currentBoardPosition == Program.totalBoardNumber)
                {
                    Console.WriteLine("Congratuation ! Player 1 Won");
                    break;
                }
                Console.WriteLine("\n\nPlayer 2 turn's....");
                player2.DiceRolls();
                player2.Move();
                if (player2.currentBoardPosition == Program.totalBoardNumber)
                {
                    Console.WriteLine("\n\nCongratuation ! Player 2 Won");
                    break;
                }
            }
            Console.WriteLine($"\nPlayer 1 rolls dice : {player1.countDiceRolls} times");
            Console.WriteLine($"\nPlayer 2 rolls dice : {player2.countDiceRolls} times");
            Console.ReadLine();
        }
    }
}