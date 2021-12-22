using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Net.Mime;

namespace KaNoBu
{
    public static class Program
    {
        static int winCounter=0;
        static int loseCounter=0;

        static void Main()
        {
            Console.WriteLine("Hello, let's begin!");
            var gameIsPlaying = true;
            do
            {
                try
                {
                    Console.WriteLine("Please, choice one of this options: 0.Rock, 1.Scissors, 2.Paper");

                    Enum.Variants userChoice = GetUserChoice(Console.ReadLine());
                    Enum.Variants compChoice = (Enum.Variants) new Random().Next(3);
                    Enum.Result roundResult = RoundResult(compChoice, userChoice);
                    Console.WriteLine(roundResult + " because AI choice is " + compChoice);
                    Console.WriteLine("Win: " + winCounter + " Lose: " + loseCounter);

                    Console.WriteLine("Press Enter to continue or Esc to exit");
                    gameIsPlaying = Console.ReadKey().Key == ConsoleKey.Enter;
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (gameIsPlaying);
        }

        public static Enum.Result RoundResult(Enum.Variants compChoice, Enum.Variants userChoice)
        {
            if (compChoice == userChoice)
            {
                return Enum.Result.Draft;
            }

            if (compChoice == Enum.Variants.Paper && userChoice == Enum.Variants.Scissors ||
                compChoice == Enum.Variants.Scissors && userChoice == Enum.Variants.Rock ||
                compChoice == Enum.Variants.Rock && userChoice == Enum.Variants.Paper)
            {
                winCounter++;
                return Enum.Result.Win;
            }

            loseCounter++;
            return Enum.Result.Lose;
        }
        public static Enum.Variants GetUserChoice(string userInput)
        {
            if (Enum.Variants.TryParse(userInput, out Enum.Variants result))
            {
                return result;
            }
            throw new Exception("The entered value is incorrect.");
        }
    }
}