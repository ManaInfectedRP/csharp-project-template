//  See https://aka.ms/new-console-template for more information
//  Hangman

using System;
using System.Diagnostics;

string[] possibleWords = ["New", "Console", "Template", "Https", "Information"];
Random getRandom = new();
string solution = possibleWords[getRandom.Next(possibleWords.Length)];

string? input;
char? guess = null;

do
{
    Console.WriteLine("Please enter a character to guess with.");
    input = Console.ReadLine();
    Debug.Assert(input != null);
    if (input.Length == 1) { guess = input[0]; }
} while ( input.Length != 1);

bool guessWasCorrect = false;

foreach (char c in solution)
{
    if (guess == c)
    {
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
