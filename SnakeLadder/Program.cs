// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace SnakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake Ladder Game\n");
            Console.WriteLine("Let's Play\n");
            Console.WriteLine("Currently you are at 0 Position\n");

            int winningPosition = 100, diceRoll, currentPlayerPosition = 0;
            int[] snake = {1,3,5,67,87,92,95,98};
            int[] ladder = {4,6,21,28,36,51,71,80};

            Random random = new Random();
            diceRoll = random.Next(1, 7);
            Console.WriteLine($"Dice Rolling Result : {diceRoll}");
           

            currentPlayerPosition+=diceRoll;

            Console.WriteLine($"You are now at position : {currentPlayerPosition}");

            if(Array.Exists(snake, x => x == currentPlayerPosition))
            {
                currentPlayerPosition-=diceRoll;
                Console.WriteLine($"\nYou reached at top of Snake , So You moved {diceRoll} steps behind\n");
            }
            if(Array.Exists(ladder, x => x == currentPlayerPosition))
            {
                Console.WriteLine($"You reached at bottom of Ladder , So You moved {diceRoll} steps ahead\n");
                currentPlayerPosition+=diceRoll;
            }
            

            Console.WriteLine($"\nYou are now at position : {currentPlayerPosition}");

            Console.ReadLine();

        }
    }
}