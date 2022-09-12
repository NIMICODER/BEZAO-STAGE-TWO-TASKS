using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_game_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string appname = "Guessing Game";
            string appVersion = "1.0.0";
            string appAuthor = "David Ukpoju";

            PrintColorMessage(ConsoleColor.Blue, $"{appname} : {appVersion} by {appAuthor}");

             Console.ResetColor();

            Random random = new Random();
            bool playAgain = true;
            bool exceededCount = false;
            
            int guess;
            int secretNumber;
            int guesses;
            string response;
            int previousNumber = 0;
          

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
             
                secretNumber = random.Next(1, 11);

                guesses++;

                    while (guess != secretNumber)
                    {



                    if(previousNumber != guess  && guess != 0)
                    {
                        guesses++;
                        previousNumber = guess;

                    }

                    PrintColorMessage(ConsoleColor.Green, "Guess a number between 1 and 11:");
                  
                        guess = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Guess: {guess}");

                    if (guess > secretNumber)
                        {
                   
                            PrintColorMessage(ConsoleColor.Red, "Your number is too large");

                        }
                        else if (guess < secretNumber)
                        {
                            PrintColorMessage(ConsoleColor.Red, "Your guess is too small");
                        }
                         if(guesses == 3)
                        {
                        exceededCount = true;
                        break;
                           
                        }
                    }

                if (exceededCount)
                {
                    PrintColorMessage(ConsoleColor.Red, "You have exceeded your number of guesses!");
                    Console.WriteLine($"Number of guesses: {guesses}");
                }
                else
                {
                    Console.WriteLine($"SecretNumber: {secretNumber}");
                    PrintColorMessage(ConsoleColor.Green, "CONGRATULATIONS, YOU ARE CORRECT!");

                    Console.WriteLine($"Number of guesses: {guesses}");
                }
                    

                    Console.WriteLine("Would you like to play again (Y/N): ");
                    response = Console.ReadLine();
                    response = response.ToUpper();

                    if (response == "Y")
                    {
                        playAgain = true;
                    }
                    else
                    {
                        playAgain = false;
                    }

              

                
            }


            PrintColorMessage(ConsoleColor.Yellow, "Thanks for playing!...");

            Console.ReadKey();


        }
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}
