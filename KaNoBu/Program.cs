using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Net.Mime;

namespace KaNoBu
{
    class Program
    {
        enum Variants 
        { 
            Rock,
            Scissors,
            Paper
        }

        enum Result
        {
            Win,
            Lose,
            Draft
        }

    static void Main()
    {
        //Variants variants = (Variants) Enum.Parse(typeof(Variants), Console.ReadLine());
        Console.WriteLine("Hello, let's begin!");
        var gameIsPlaying = true;
        do
        {
            try
            { 
                Console.WriteLine("Please, choice one of this options: 0.Rock, 1.Scissors, 2.Paper");
                Variants userChoice = GetUserChoice(Console.ReadLine());
                
                Variants compChoice = (Variants) new Random().Next(3);



                Result roundResult = RoundResult(compChoice, userChoice);
                Console.WriteLine(roundResult + " because AI choice is " + compChoice);
                
                Console.WriteLine("Press Enter to continue or Esc to exit");
                gameIsPlaying = Console.ReadKey().Key == ConsoleKey.Enter;
            }
                
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        while (gameIsPlaying);
    }

    static Result RoundResult(Variants compChoice, Variants userChoice)
    {
        Result roundResult;

        if (compChoice == userChoice)
        {
            roundResult = Result.Draft;
        }
        else if (compChoice == Variants.Paper && userChoice == Variants.Scissors ||
                 compChoice == Variants.Scissors && userChoice == Variants.Rock ||
                 compChoice == Variants.Rock && userChoice == Variants.Paper)
        {
            roundResult = Result.Win;
        }

        else
        {
            roundResult = Result.Lose;
        }
        return roundResult;
    }

    static Variants GetUserChoice(string userInput)
    {
        if (Variants.TryParse(userInput, out Variants result))
        {
            if (result == Variants.Rock || result == Variants.Paper || result == Variants.Scissors)
            {
                return result;
            }
        }
        throw new Exception("The entered value is incorrect.");
    }


    }
    }