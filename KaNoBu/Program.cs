using System.Diagnostics;
using System.Net.Mime;

namespace KaNoBu
{
    class Program
    {

        static void Main()
        {
            
            string userChoice = "";
            Console.WriteLine("Hello, let's begin!");
            do
            {
                Console.WriteLine("Please, choice one of this options: Rock, Scissors, Paper");
                userChoice = Console.ReadLine();

                while (userChoice != "Rock" && userChoice != "Scissors"&& userChoice != "Paper")
                    
                {
                    Console.WriteLine("The entered value is incorrect. Try again");
                    userChoice = Console.ReadLine();
                }
                
                string compChoice = ((Variants)new Random().Next(3)).ToString();
                
                Console.WriteLine("AI Choice: " + compChoice);

                //

                ResultCalculation resultCalculation = new ResultCalculation();
                resultCalculation.GetGameResult(userChoice, compChoice);
                
                
                Console.WriteLine("Press Enter to continue or Esc to exit");
            }
            while (Console.ReadKey().Key == ConsoleKey.Enter);
        }
        private enum Variants { 
        Rock,
        Scissors,
        Paper
        }
    } 
}