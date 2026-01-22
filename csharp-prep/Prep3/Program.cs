using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("What is the magic number? ");
        // string userInput = Console.ReadLine();
        // int number = int.Parse(userInput);

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        int guess = 0;

        while (guess != number)
        {
            Console.WriteLine("What is your guess? ");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);

            if (guess > number)
            {
              Console.WriteLine("Lower");
            }

            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("You've got it! ");
            }
        }     
    }    
}