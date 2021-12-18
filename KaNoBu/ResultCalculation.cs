namespace KaNoBu;

public class ResultCalculation
{
     public void GetGameResult(string userChoice, string compChoice)
     {
         int w = 0, l = 0;
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
     }
}