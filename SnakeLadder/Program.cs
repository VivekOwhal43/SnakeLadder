﻿// See https://aka.ms/new-console-template for more information
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

            int totalBoardNumber = 100, diceNumber, currentBoardPosition = 0, countDiceRolls = 1;


            Random random = new Random();

            while (currentBoardPosition < totalBoardNumber)
            {
                int[] snake = { 1, 3, 5, 67, 87, 92, 95, 98 };
                int[] ladder = { 4, 6, 21, 28, 36, 51, 71, 80 };
                diceNumber = random.Next(1, 7);
                Console.WriteLine($"\n\n\nAfter rolling Dice,The number display on the Dice is : {diceNumber}");

                currentBoardPosition += diceNumber;

                Console.WriteLine($"\nYou are now at position : {currentBoardPosition}");

                if (Array.Exists(snake, x => x == currentBoardPosition))
                {
                    currentBoardPosition -= diceNumber;
                    Console.WriteLine($"\nYou reached at top of Snake , So You moved {diceNumber} steps behind");
                }
                if (Array.Exists(ladder, x => x == currentBoardPosition))
                {
                    Console.WriteLine($"\nYou reached at bottom of Ladder , So You moved {diceNumber} steps ahead");
                    currentBoardPosition += diceNumber;
                }
                if (currentBoardPosition > 100)
                {
                    Console.WriteLine("You are out of range");
                    currentBoardPosition -= diceNumber;
                }
                if (currentBoardPosition < 0)
                {
                    currentBoardPosition = 0;
                }
                countDiceRolls += 1;

                Console.WriteLine($"\nYou are now at position : {currentBoardPosition}");
            }

            Console.WriteLine($"Number of times dice rolls to win : {countDiceRolls}");
            Console.ReadLine();
        }
    }
}