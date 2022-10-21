using System;


namespace RockPaperScissor
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";


                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("Enter ROCK, PAPER, or SCISSORS:");

                    player = Console.ReadLine();
                    player = player.ToUpper();
                }


                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Player: " + player);
                Console.ResetColor();

                Console.BackgroundColor = ConsoleColor.Red;

                Console.WriteLine("Computer: " + computer);
                Console.ResetColor();

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("It's a DRAW!");
                            Console.ResetColor();
                        }
                        else if (computer == "PAPER")
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("You Lose!");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.WriteLine("You Win!");
                            Console.ResetColor();
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.WriteLine("You Win!");
                            Console.ResetColor();
                        }
                        else if (computer == "PAPER")
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("It's a DRAW!");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("You Lose!");
                            Console.ResetColor();
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("You Lose!");
                            Console.ResetColor();
                        }
                        else if (computer == "PAPER")
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.WriteLine("You Win!");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.WriteLine("It's a DRAW!");
                            Console.ResetColor();
                        }
                        break;
                }

                Console.WriteLine(" Would you Like to playe again (Y/N):");
                answer = Console.ReadLine();
                answer = answer.ToUpper();


                if (answer == "Y")
                {
                    playAgain = true;
                } else {
                    playAgain = false;
                }
            }
            Console.WriteLine("Thanks for Playing!");
            Console.ReadKey();     
        }
    }
}
