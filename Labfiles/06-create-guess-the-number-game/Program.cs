// Set up the game
Random random = new Random();
int secretNumber = random.Next(1, 21);
int maxGuesses = 5;
int guessCount = 0;
bool hasWon = false;

Console.WriteLine("I'm thinking of a number between 1 and 20.");
Console.WriteLine($"You have {maxGuesses} guesses. Good luck!");

for (; guessCount < maxGuesses; guessCount++)
{
    // Ask the player to guess
    Console.Write($"\nGuess #{guessCount + 1}: ");

    int guessedNumber;
    while (!int.TryParse(Console.ReadLine(), out guessedNumber))
    {
        Console.Write($"That's an invalid number. Try again.\nGuess #{guessCount + 1}: ");
    }

    int guessesLeft = maxGuesses - guessCount - 1;

    // Check the guess and give feedback
    if (guessedNumber == secretNumber)
    {
        hasWon = true;
        Console.WriteLine($"Correct! You got it in {guessCount + 1} guesses.");
        break;
    }
    else if (guessedNumber != secretNumber && guessesLeft != 0)
    {
        if (guessedNumber > secretNumber)
        {
            Console.WriteLine($"Too high! You have {guessesLeft} guesses left.");
        }
        else
        {
            Console.WriteLine($"Too low! You have {guessesLeft} guesses left.");
        }
    }
}

// Announce the result
if (!hasWon)
{
    Console.WriteLine($"Out of guesses! The secret number was {secretNumber}.");
}
