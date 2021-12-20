using System.Diagnostics;
using System.Net.Mime;

namespace KaNoBu
{
    class Program
    {
        static int w = 0, l=0;


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

                
                
                var (win, lose) =  RoundResultPrint(userChoice, compChoice, w, l);
                
                Console.WriteLine("Win:"+win+"\n"+"Lose:"+lose);

                Console.WriteLine("Press Enter to continue or Esc to exit");
            }
            while (Console.ReadKey().Key == ConsoleKey.Enter);
        }
         enum Variants { 
         Rock,
         Scissors,
         Paper
         }

         static (int w, int l) RoundResultPrint(string userChoice, string compChoice, int w, int l)
         {

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

             return (w, l);
         }


    } 
}