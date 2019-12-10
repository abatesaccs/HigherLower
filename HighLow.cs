using System;

public class Game
{
    public int Max = 101;
    public int Min = 1;

    public int InitializeNumber(int min, int max)
    {
        Random random = new Random();
        int randomNum = random.Next(min, max);
        return randomNum;
    }

    public bool makeGuess(int number)
    {
        Console.Write("Is your number higher or lower than " + number +"? (H/L/C)");
        string userInput = Console.ReadLine().ToLower();

        Random random = new Random();
        int randomNum = 1;
        bool check = true;
        switch(userInput)
        {
            case "h":
                if(number == 100)
                {
                    Console.WriteLine("Cannot go higher.");
                    randomNum = number;
                    break;
                }
                Console.WriteLine("Higher!");
                Min = number + 1;
                randomNum = random.Next(Min, Max);
                break;
            case "l":
                Console.WriteLine("Lower!");
                Max = number;
                randomNum = random.Next(Min, Max);
                break;
            case "c":
                Console.WriteLine("Correct!");
                check = false;
                break;
            default:
                Console.WriteLine("Default");
                break;
        }
        while(check)
        {
            return makeGuess(randomNum);
        }
        return true;
    }

    static void Main()
    {
        Console.WriteLine("Let's play higher/lower game.");
        Console.WriteLine("Guest a number between 1 - 100.");
        
        Game game = new Game();
        int randomNum = game.InitializeNumber(1, 101);
        game.makeGuess(randomNum);
    }
}