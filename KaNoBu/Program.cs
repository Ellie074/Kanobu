using System.Diagnostics;
using System.Net.Mime;

namespace KaNoBu
{
    class Program
    {

        static void Main()
        {
            int w = 0, l = 0;
            Console.WriteLine("Hello, let's begin!");
            do
            {
                Console.WriteLine("Please, choice one of this options: Rock, Scissors, Paper");
                
                string userChoice = Console.ReadLine();

                // while (userChoice != "Rock" || userChoice != "Scissors"|| userChoice != "Paper")
                // {
                //     Console.WriteLine("The entered value is incorrect. Try again");
                //     
                // }

                //

                int compValue = new Random().Next(3);
                string compChoice = "";

                switch (compValue)
                {
                    case 0:
                    {
                        compChoice = Variants.Rock.ToString();
                        break;
                    }
                    case 1:
                    {
                        compChoice = Variants.Scissors.ToString();
                        break;
                    }
                    case 2:
                    {
                        compChoice = Variants.Paper.ToString();
                        break;
                    }
                }

                Console.WriteLine("AI Choice: " + compChoice);

                //


                switch (userChoice)
                {
                    case "Rock":
                    {
                        if (compChoice == "Rock")
                        {
                            Console.WriteLine("Draft");
                        }
                        else if (compChoice == "Scissors")
                        {
                            Console.WriteLine("You Win");
                            w++;
                        }
                        else
                        {
                            Console.WriteLine("You Lose");
                            l++;
                        }

                        break;
                    }

                    case "Scissors":
                    {
                        if (compChoice == "Rock")
                        {
                            Console.WriteLine("You Lose");
                            l++;
                        }
                        else if (compChoice == "Scissors")
                        {
                            Console.WriteLine("Draft");
                        }
                        else
                        {
                            Console.WriteLine("You Win");
                            w++;
                        }

                        break;
                    }

                    case "Paper":
                    {
                        if (compChoice == "Rock")
                        {
                            Console.WriteLine("You Win");
                            w++;
                        }
                        else if (compChoice == "Scissors")
                        {
                            Console.WriteLine("You Lose");
                            l++;
                        }
                        else
                        {
                            Console.WriteLine("Draft");
                        }
                        break;
                    }
                }
                Console.WriteLine("Win:"+w+"\n"+"Lose:"+l);
                Console.WriteLine("Press Enter to continue or Esc to exit");

                // var key = Console.ReadKey().Key;
                //
                // if (key == ConsoleKey.Spacebar)
                // {
                //     Environment.Exit(0);
                // }
            }
            while (Console.ReadKey().Key == ConsoleKey.Enter);
        }
        public enum Variants { 
        Rock = 0,
        Scissors = 1,
        Paper = 2
        }
    } 
}