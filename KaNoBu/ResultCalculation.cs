using System.Diagnostics;

namespace KaNoBu;

public class ResultCalculation
{
    enum Variants { 
        Rock,
        Scissors,
        Paper
    }

    public void GetGameResult(string choice)
    {
        Console.WriteLine("Hello, let's begin!");
        do
        {
            Console.WriteLine("Please, choice one of this options: 0.Rock, 1.Scissors, 2.Paper");
            Console.WriteLine("Your choice must be a number!");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            int compChoice = new Random().Next(3);

            Variants userEnum = ConvertChoiceToEnum(userChoice);
            Variants compEnum = ConvertChoiceToEnum(compChoice);

            string roundResult = RoundResilt(compEnum, userEnum);
            Console.WriteLine(roundResult);
            
            Console.WriteLine("Press Enter to continue or Esc to exit");
        }
        while (Console.ReadKey().Key == ConsoleKey.Enter);
    }

    private Variants ConvertChoiceToEnum(int choice)
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

    private string RoundResilt(Variants compEnum, Variants userEnum)
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
}