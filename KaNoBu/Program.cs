using System.Diagnostics;

namespace KaNoBu
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Hello, let's begin! Please, choice one of this options: Rock, Scissors, Paper");
            
            int compValue = new Random().Next(3);

            string userChoice = Console.ReadLine();

            //

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
            
            Console.WriteLine("AI Choice: "+ compChoice);

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
                    }
                    else
                    {
                        Console.WriteLine("You Lose");
                    }
                    break;
                }
                
                case "Scissors":
                {
                    if (compChoice == "Rock")
                    {
                        Console.WriteLine("You Lose");
                    }
                    else if (compChoice == "Scissors")
                    {
                        Console.WriteLine("Draft");
                    }
                    else
                    {
                        Console.WriteLine("You Win");
                    }
                    break;
                }
                
                case "Paper":
                {
                    if (compChoice == "Rock")
                    {
                        Console.WriteLine("You Win");
                    }
                    else if (compChoice == "Scissors")
                    {
                        Console.WriteLine("You Lose");
                    }
                    else
                    {
                        Console.WriteLine("Draft");
                    }
                    break;
                }
            }
           
        }
        public enum Variants { 
        Rock = 0,
        Scissors = 1,
        Paper = 2
        }
    } 
}