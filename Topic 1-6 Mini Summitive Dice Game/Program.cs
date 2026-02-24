namespace Topic_1_6_Mini_Summitive_Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool done = false;

            Die die1;
            Die die2;

            int userBet;
            int userBank = 100;
            string userChoice;
            string choice;

            die1 = new Die(ConsoleColor.Red);
            die2 = new Die(ConsoleColor.Red);

            int roll1 = die1.Roll;
            int roll2 = die2.Roll;
            int sum = roll1 + roll2;

            Console.WriteLine("Welcome to the casino dice game!");
            Console.WriteLine("You will be guessing what the die is base on the guesses provided soon");
            Console.WriteLine("The amount you win for each guess is as follows:");
            Console.WriteLine("Double - 2X your bet");
            Console.WriteLine("Not Double - 1/2 your bet");
            Console.WriteLine("Even Sum -  Your bet (if you bet $5 you get it back)");
            Console.WriteLine("Odd Sum - Your bet (if you bet $5 you get it back)");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue into the betting part");
            Console.ReadLine();
            Console.Clear();

            while (!done)
            {

                Console.Write("How much would you like to bet? ");
                Console.WriteLine($"You have {userBank.ToString("C")} to bet with.");
                Console.Write("Your bet:");
                while (!Int32.TryParse(Console.ReadLine(), out userBet) || userBet < 0 || userBet > userBank) 
                {
                    Console.WriteLine();
                    Console.Write("Invalid bet. Please enter another bet:");
                }
                Console.WriteLine();
                Console.WriteLine("What do you think the roll will be?");
                Console.WriteLine("------------------");
                Console.WriteLine("Double     Not Double");
                Console.WriteLine();
                Console.WriteLine("Even Sum   Odd Sum ");
                Console.WriteLine("------------------");
                Console.Write("Your choice: ");
                userChoice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();
                die1.DrawRoll();
                die2.DrawRoll();
                Console.WriteLine();

                if (die1.Roll == die2.Roll && userChoice == "double")
                {
                    Console.WriteLine("You rolled doubles! You won double your bet which will be added to your bank.");
                    userBank = userBet * 2 + userBank;
                    Console.WriteLine($"You now have {userBank.ToString("C")} as your balance to bet with");
                }
                else if (die1.Roll != die2.Roll && userChoice == "not double")
                {
                    Console.WriteLine("You rolled not double! You win half your bet back");
                    userBank = userBet / 2 + userBank;
                    Console.WriteLine($"You now have {userBank.ToString("C")} as your balance to bet with");
                }
                else if (sum % 2 == 0 && userChoice == "even sum")
                {
                    Console.WriteLine("You rolled even sum! You win your bet back");
                    userBank = userBet + userBank;
                    Console.WriteLine($"You now have {userBank.ToString("C")} as your balance to bet with");
                }
                else if (sum % 2 != 0 && userChoice == "odd sum")
                {
                    Console.WriteLine("You rolled odd sum! You win your bet back");
                    userBank = userBet + userBank;
                    Console.WriteLine($"You now have {userBank.ToString("C")} as your balance to bet with");
                }
                else
                {
                    Console.WriteLine("Sorry but your guess wasn't correct, so you lost your bet");
                    userBank = userBank - userBet;
                    Console.WriteLine($"You now have {userBank.ToString("C")} as your balance to bet with");
                }
                Console.WriteLine();

                if (userBank == 0)
                {
                    Console.WriteLine("Sorry but you ran out of money and will have to come back with more money");
                    done = true;
                }
                else if (userBank != 0)
                {
                    die1.RollDie();
                    die2.RollDie();

                    Console.WriteLine("Press Enter if you want to quit or type 'y' if you want to continue to bet");
                    Console.WriteLine();
                    choice = Console.ReadLine().ToLower().Trim();
                    Console.Clear();
                    if (choice != "y")
                    {
                        Console.WriteLine("Thank you and have a nice day! :)");
                        Console.WriteLine($"You ended with {userBank.ToString("C")} in your bank");
                        done = true;
                    }
                }

            }
        }
    }
}
