using System;

namespace Iteration___Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4- Write a program that picks a random number between 1 and 10. 
            //Give the user 4 chances to guess the number. 
            //If the user guesses the number, display “You won"; otherwise, display “You lost". 
            //(To make sure the program is behaving correctly, you can display the secret number on the console first.)


            Random randomNumber = new Random();
            int randomAnswer = randomNumber.Next(1, 10);
            Console.WriteLine($"Secret answer is {randomAnswer}");

            Console.WriteLine("The computer will pick a random number between 1 & 10, can you guess what it is!??");
            Console.WriteLine("Please enter your guess...");
            
            int maximumUserGuesses = 4;
            int attempts = 1;
            int userGuess = Convert.ToInt32(Console.ReadLine());
            int attemptsRemaining = maximumUserGuesses - attempts;
            
            while (attempts < maximumUserGuesses && userGuess != randomAnswer)
            {
                Console.WriteLine($"Try again...you have {attemptsRemaining} attempts remaining");
                attempts++;
                attemptsRemaining--;
                userGuess = Convert.ToInt32(Console.ReadLine());
            }
         
            if (userGuess == randomAnswer)
            {
                Console.WriteLine("YOU WON !!!");
            }
            else
            {
                Console.WriteLine("YOU LOST....LOSER!");
            }
        }
    }
}
