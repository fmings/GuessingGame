
void Main()
{
    Console.WriteLine("Welcome to the Guessing Game!");
    Console.WriteLine(@"Please select a level:
                    1. Easy
                    2. Medium
                    3. Hard");
    string levelInput = Console.ReadLine();

    if (int.TryParse(levelInput, out int selectedLevel) && selectedLevel > 0 && selectedLevel < 4)
    {
        int attempts = GetAttempts(selectedLevel);
        if (attempts > 0)
        {
            PlayGuessingGame(attempts);
        }
        else
        {
            Console.WriteLine("Invalid level selected.");
        }
    }
    else
    {
        Console.WriteLine("That is not an existing level. Please enter a level between 1-3.");

    }
}

int GetAttempts(int selectedLevel)
{
        int attempts = 0;

        if (selectedLevel == 1)
        {
            attempts = 8;
        }
        else if (selectedLevel == 2)
        {
            attempts = 6;
        }
        else if (selectedLevel == 3)
        {
            attempts = 4;
        }
    return attempts;
}


Random random = new Random();

void PlayGuessingGame(int attempts)
{
    Console.WriteLine("Guess a number between 1 and 100");
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
                    Console.WriteLine($"Tooooo bad...you guessed {(guessedNumber > secretNumber ? "too high!" : "too low!")}! You have {attempts - (i + 1)} guesses remaining. Try again:");
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
}

Main();