namespace Topic_1_6_Mini_Summitive_Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool done = false;

            int userBet;
            int userBank = 100;
            string userChoice;

            while (!done)
            {
                Console.Write("How much would you like to bet: ");
                while (!Int32.TryParse(Console.ReadLine(), out userBet) || userBet < 0 || userBet > userBet) 
                {
                    Console.Write("Invalid bet. Please enter another bet:");
                    Console.ReadLine();
                }

                Console.WriteLine("What do you think the roll will be?");
                Console.WriteLine("------------------");
                Console.WriteLine("Double     Not Double");
                Console.WriteLine();
                Console.WriteLine("Even Sum   Odd Sum ");
                Console.WriteLine("------------------");
                Console.Write("Your choice: ");
                userChoice = Console.ReadLine().ToLower().Trim();
                
            }
        }
    }
}
