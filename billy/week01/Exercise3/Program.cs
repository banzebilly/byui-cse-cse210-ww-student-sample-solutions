//author: Banze Billy
// passed the requirement added a way if they can keep playing by using a nested while loop

Random randomGenerator = new Random();
int magicNumber = randomGenerator.Next(1, 101);


string playAgain = "yes";

while (playAgain == "yes")
{
    
    int guess = -1;
    int guessCount = 0;

    while (guess != magicNumber)
    {
        Console.Write("Guess a number? ");
        guess = int.Parse(Console.ReadLine());
        guessCount++;

        if (magicNumber > guess)
        {
            Console.WriteLine("Higher");
        }
        else if (magicNumber < guess)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }

        Console.WriteLine($"It took you {guessCount} guesses.");
    }

    Console.Write("Do you want to play again? ");
    playAgain = Console.ReadLine();

    if (playAgain == "no")
    {
        Console.WriteLine("Well done! See you next time.");
    }
}















// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // For Parts 1 and 2, where the user specified the number...
//         // Console.Write("What is the magic number? ");
//         // int magicNumber = int.Parse(Console.ReadLine());
        
//         // For Part 3, where we use a random number
//         Random randomGenerator = new Random();
//         int magicNumber = randomGenerator.Next(1, 101);

//         int guess = -1;

//         // We could also use a do-while loop here...
//         while (guess != magicNumber)
//         {
//             Console.Write("What is your guess? ");
//             guess = int.Parse(Console.ReadLine());

//             if (magicNumber > guess)
//             {
//                 Console.WriteLine("Higher");
//             }
//             else if (magicNumber < guess)
//             {
//                 Console.WriteLine("Lower");
//             }
//             else
//             {
//                 Console.WriteLine("You guessed it!");
//             }

//         }                    
//     }
// }
