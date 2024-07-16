Console.WriteLine("Welcome to the Guessing Game!");
Console.WriteLine("Guess a number between 1 and 100");

int attempts = 4;
Random random = new Random();

int secretNumber;
secretNumber = random.Next(0, 101);
for (int i = 0; i < attempts; i++)
{
    string guessedNumberInput = Console.ReadLine();
    if (int.TryParse(guessedNumberInput, out int guessedNumber) && guessedNumber > 0 && guessedNumber <= 100)
    {
        Console.WriteLine($"This is guess number {i + 1} and you guessed {guessedNumber}. Let's see if it is the secret number...");
        if (guessedNumber == secretNumber)
        {
            Console.WriteLine("Congratulations!! You guessed the secret number!");
            break;
        }
        else
        {
            if (i < attempts - 1)
            {
                Console.WriteLine($"Tooooo bad...you guessed wrong! You have {attempts - (i + 1)} guesses remaining. Guess again:");
            }
            else
            {
                Console.WriteLine($"Tooooo bad...you guessed wrong! No more attempts remaining. The secret number is {secretNumber}.");
            };

        }
    }
    else
    {
        Console.WriteLine("Invalid guess. Please guess a number between 1 and 100.");
        i--;
    }
}

