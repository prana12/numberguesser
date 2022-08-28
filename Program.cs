using System;

//Namespace
namespace NumberGuesser
{
    //Class
    internal class Program
    {
        //Entry Point
        static void Main(string[] args)
        {
            /*string name = "Prakash";
            int age = 30;
            Console.WriteLine("Hello " + name + ", your age is " + age);
            Console.WriteLine("{0} is {1}", name, age);*/

            GetAppInfo();

            GreetUser();

            while (true)
            {

                //int correctNumber = 7;
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");
                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number");
                        continue;
                    }

                    //guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong Number, please try again");
                    }
                }
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT");

                Console.WriteLine("Play Again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

        }

        static void GetAppInfo() {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Prakash";

            //change text colour
            Console.ForegroundColor = ConsoleColor.Green;

            //write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }

        static void GreetUser() {
            //ask users name
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
