using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new();  //Creates a new Random called random//

            while (true)  //Only executes indented code if playAgain is true//
            {
                int Guess = 0;  //Sets the integer 0 to the variable Guess//
                int Guesses = 0;  //Sets the integer 0 to the variable Guesses//
                String Response = "";  //Sets an empty string to the variable Response//

                int Number = random.Next(1, 101);  //Creates a new random whole number between 1 and 100//

                while (Guess != Number)  //Only executes the indented code if Guess is not equal to number//
                {
                    Console.Write($"Guess a number between 1 and 100: ");
                    Guess = Convert.ToInt32(Console.ReadLine());  //Converts the inputted string in the line above to a 32 bit integer//

                    if (Guess > Number)  //Only executes the indented code if Guess is larger than Number//
                    {
                        Console.WriteLine($"{Guess} is too high");
                        Console.Write("Guess again: ");
                    }

                    else if (Guess < Number)  //Only executed the indented code if Guess is smaller than Number//
                    {
                        Console.WriteLine($"{Guess} is too low");
                        Console.WriteLine("Guess again: ");
                    }
                    Guesses++;  //Increases the variable Guesses by 1//
                }
                Console.WriteLine($"Well Done! You guessed the number in {Guesses} guesses!");
                Console.Write("Do you want to play again? (Y/N): ");
                Response = Console.ReadLine();  //Reads the line above and adds it to response//
                Response = Response.ToUpper();  //Changes Response to all upper cases//

                if (Response == "Y")  //Only executes the indented code if Response is Y//
                {
                    continue;
                }

                else if (Response == "N")  //Only executes the indented code if Response is N//
                {
                    break;
                }
            }
        }
    }
}


