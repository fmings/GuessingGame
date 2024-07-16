Console.WriteLine("Welcome to the Guessing Game!");
Console.WriteLine("Guess a number between 1 and 100");
string guessedNumberInput = Console.ReadLine();
if (int.TryParse(guessedNumberInput, out int guessedNumber) && guessedNumber > 0 && guessedNumber <= 100)
{
    Console.WriteLine($"Let's see if you guessed correctly...");
    if (guessedNumber == 42)
    {
        Console.WriteLine("Congratulations!! You guessed the secret number!");
    }
    else
    {
        Console.WriteLine("Tooooo bad...you guessed wrong!");
    }
}
else
{
    Console.WriteLine("Invalid guess. Please guess a number between 1 and 100.");
}
int secretNumber = 42;
