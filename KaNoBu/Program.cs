using System.Diagnostics;
using System.Net.Mime;

namespace KaNoBu
{
    class Program
    {
        enum Variants { 
        Rock,
        Scissors,
        Paper }

    static void Main()
    {
        Console.WriteLine("Hello, let's begin!");
        do
        {
            Console.WriteLine("Please, choice one of this options: 0.Rock, 1.Scissors, 2.Paper");
            Console.WriteLine("Your choice must be a number!");

            int userChoice = GetUserChoice();
            
            int compChoice = new Random().Next(3);

            Variants userEnum = ConvertChoiceToEnum(userChoice);
            Variants compEnum = ConvertChoiceToEnum(compChoice);

            string roundResult = RoundResult(compEnum, userEnum);
            Console.WriteLine(roundResult + " because AI choice is " + compEnum);
            
            Console.WriteLine("Press Enter to continue or Esc to exit");
        }
        while (Console.ReadKey().Key == ConsoleKey.Enter);
    }

    static Variants ConvertChoiceToEnum(int choice)
    {
        Variants result = Variants.Rock;
        switch (choice)
        {
            case 0:
            {
                break;
            }
            case 1:
            {
                result = Variants.Scissors;
                break;
            }
            case 2:
            {
                result = Variants.Paper;
                break;
            }
        }

        return result;
    }

    static string RoundResult(Variants compEnum, Variants userEnum)
    {
        string roundResult = "";
        
         switch (compEnum)
                    {
                        case Variants.Rock:
                        {
                            if (userEnum == Variants.Paper)
                            {
                                roundResult = "You Win";
                            }
                            else if (userEnum == Variants.Scissors)
                            {
                                roundResult = "You Lose";
                            }
                            else
                            {
                                roundResult = "Draft";
                            }
                            break;
                        }
                        case Variants.Scissors:
                        {
                            if (userEnum == Variants.Paper)
                            {
                                roundResult = "You Lose";
                            }
                            else if (userEnum == Variants.Rock)
                            {
                                roundResult = "You Win";
                            }
                            else
                            {
                                roundResult = "Draft";
                            }
                            break;
                        }
                        case Variants.Paper:
                        {
                            if (userEnum == Variants.Rock)
                            {
                                roundResult = "You Lose";
                            }
                            else if (userEnum == Variants.Scissors)
                            {
                                roundResult = "You Win";
                            }
                            else
                            {
                                roundResult = "Draft";
                            }
                            break;
                        }
        
                    }

         return roundResult;
    }
    
    static int GetUserChoice() 
    {
        int result;
        do {
            string userInput = Console.ReadLine();
            if(Int32.TryParse(userInput, out result)) 
            {
                if (result  == 0 || result == 1 || result == 2)
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("The entered value is incorrect. Your choice must be a 0.Rock, 1.Scissors or 2.Paper");
                }
            }
            else 
            {
                Console.WriteLine("The entered value is incorrect. Your choice must be a number!");
            }
        } 
        while(true);
    }
    } 
}