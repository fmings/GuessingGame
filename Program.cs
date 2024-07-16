Console.WriteLine("Welcome to the Guessing Game!");
Console.WriteLine("Guess a number between 1 and 100");

int attempts = 4;
int secretNumber = 42;
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
                Console.WriteLine("Tooooo bad...you guessed wrong! Guess again:");
            }
            else
            {
                Console.WriteLine("Tooooo bad...you guessed wrong! No more attempts remaining.");
            };

        }
    }
    else
    {
        Console.WriteLine("Invalid guess. Please guess a number between 1 and 100.");
        i--;
    }
}

