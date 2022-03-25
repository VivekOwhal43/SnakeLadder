// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Security.Cryptography.X509Certificates;

namespace SnakeLadder
{
    class Program
    {
        public const int winningPosition = 10;
        int dice_score = 0;
        static int attempt_number = 1;
        int dieRoll;
        static int current_position = 0;

        static void Main(string[] args)
        {
            Random random = new Random();
            int current_dice_number = random.Next(1, 7);
            Console.WriteLine("========== Welcome To Snake and Ladder ===========");
            Console.WriteLine($"Your Attempt No is: {attempt_number}");
            Console.WriteLine($"You got {current_dice_number} number on dice");
            Console.WriteLine($"Your current position is: {current_position + current_dice_number}");
        }
    }
}