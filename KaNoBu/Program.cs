namespace KaNoBu
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Hello, let's begin! Please, choice one of this options: Rock, Scissors, Paper");
            
            int compValue = new Random().Next(3);

            string? userChoice = Console.ReadLine();

            int userValue = 0;
            switch (userChoice)
            {
                case "Rock":
                {
                    userValue = Convert.ToInt32(Variants.Rock);
                    break;
                }
                case "Scissors":
                {
                    userValue = Convert.ToInt32(Variants.Scissors);
                    break;
                }
                case "Paper":
                {
                    userValue = Convert.ToInt32(Variants.Paper);
                    break;
                }
            }

            if (compValue == userValue)
            {
                Console.WriteLine("AI Choice: "+ compValue);
                Console.WriteLine("Draft");
            }
            else if (compValue > userValue)
            {
                Console.WriteLine("AI Choice: "+ compValue);
                Console.WriteLine("You Lose");
            }
            else
            {
                Console.WriteLine("AI Choice: "+ compValue);
                Console.WriteLine("You Win");
            }
        }
        public enum Variants { 
        Rock = 0,
        Scissors = 1,
        Paper = 2
        }
    } 
}