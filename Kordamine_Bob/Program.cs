using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace Kordamine_Bob
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
            
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option"); 
            Console.WriteLine("1. Print Numbers"); 
            Console.WriteLine("2. Guessing game"); 
            Console.WriteLine("Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print numbers!");
            Console.Write("Type a number: ");
            int number = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < number+1)
            {
                Console.Write(counter + "-");
                counter++;
            }

            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing game!");
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 11);
            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10");
                string result = Console.ReadLine();
                guesses++;
                if (result == randomNumber.ToString())
                {
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }
            } while (incorrect);
            Console.WriteLine("Correct! It took you {0} guesses", guesses);
            Console.ReadLine();

        }
    }
}
