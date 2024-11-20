//  See https://aka.ms/new-console-template for more information
//  Hangman

using System.Diagnostics;

string[] possibleWords = ["New", "Console", "Template", "Https", "Information"];
Random getRandom = new();
string solution = possibleWords[getRandom.Next(possibleWords.Length)];
string display = new('_', solution.Length);

Console.WriteLine(display);

string guess = GetUserGuess();
bool guessWasCorrect = false;

for (int i = 0; i < solution.Length; i += 1)
{
    if (guess[0] == solution[i])
    {
        display.Remove(i, 1);
        display.Insert(i, guess);
        guessWasCorrect = true;
    }
}

if (guessWasCorrect)
{
    Console.WriteLine($"{guess} exists in the word");
}
else
{
    Console.WriteLine($"{guess} didn't exist in the word");
    
}

string GetUserGuess()
{
    string? guess = null;
    do
    {
        Console.WriteLine("Please enter a character to guess with.");
        string? input = Console.ReadLine();
        Debug.Assert(input != null);
        if (input.Length == 1) { guess = input; }
    } while ( guess == null);
    
    return guess;
}

