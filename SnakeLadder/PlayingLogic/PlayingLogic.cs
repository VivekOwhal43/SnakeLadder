using System;
using System.Security;

namespace SnakeLadder
{

}
public class PlayingLogic
{
    public const int winningPosition = 10;
    int dice_score = 0;
    static int attempt_number = 1;
    int dieRoll;
    static int current_position = 0;

    public void play()
    {
        Random random = new Random();
        int current_dice_number = random.Next(1, 7);
        Console.WriteLine($"Your Attempt No is: {attempt_number}");
        Console.WriteLine($"You got {current_dice_number} number on dice");
        current_position +=current_dice_number;
        Console.WriteLine($"Your current position is: {current_position}");
    }

    public void noPlay()
    {
        
    }
}