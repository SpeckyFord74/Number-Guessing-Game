using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new();  //Creates a new Random called random//

            bool playAgain = true;  //Creates a bool variable called playAgain and makes it equal true//
            int Min = 1;  //Creates a integer variable called Min and makes it equal 1//
            int Max = 100;  //Creates a integer variable called Max and makes it equal 100//
            int Guess;  //Creates a integer variable called Guess and doesn't set it a value//
            int Number;  //Creates a integer variable called Number and doesn't set it a value//
            int Guesses;  //Creates a integer variable called Guesses and doesn't set it a value//
            String Response;  //Creates a string variable called Response but doesn't set it a value//

            while (playAgain)  //Only executes indented code if playAgain is true//
            {
                Guess = 0;  //Sets the integer 0 to the variable Guess//
                Guesses = 0;  //Sets the integer 0 to the variable Guesses//
                Response = "";  //Sets an empty string to the variable Response//

                Number = random.Next(Min, Max + 1);  //Creates a new random whole number between 1 and 100//

                while (Guess != Number)  //Only executes the indented code if Guess is not equal to number//
                {
                    Console.Write($"Guess a number between {Min} and {Max}: ");
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
                    playAgain = true;  //Keeps the boolean variable as True//
                }

                else if (Response == "N")  //Only executes the indented code if Response is N//
                {
                    playAgain = false;  //Keeps the boolean variable as False//
                }
            }
        }
    }
}


