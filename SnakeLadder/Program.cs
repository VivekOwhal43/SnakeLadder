// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Security.Cryptography.X509Certificates;

namespace SnakeLadder
{
    class Program
    {
        public const int winningPosition = 10;
        int dice_score = 0;
        static int attempt_number = 0;
        int dieRoll;
        static int current_position = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("========== Welcome To Snake and Ladder ===========");
            Console.WriteLine($"Your Attempt No is: {attempt_number}");
            Console.WriteLine($"Your current position is: {current_position}");
        }
    }
}