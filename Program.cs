Console.WriteLine("Welcome to the Guessing Game!");
Console.WriteLine("Guess a number between 1 and 100");
string guessedNumberInput = Console.ReadLine();
if (int.TryParse(guessedNumberInput, out int guessedNumber) && guessedNumber > 0 && guessedNumber <= 100)
{
    Console.WriteLine($"You guessed {guessedNumber}");
}
else
{
    Console.WriteLine("Invalid guess. Please guess a number between 1 and 100.");
}
