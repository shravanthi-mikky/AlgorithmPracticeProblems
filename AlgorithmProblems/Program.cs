// See https://aka.ms/new-console-template for more information
using AlgorithmProblems;

Console.WriteLine("Algorithm Practice Problems!");
Anagram anagram = new();
Console.WriteLine("Please enter the two strings to find if they are anagrams or not. :");
string first = Console.ReadLine();
string second = Console.ReadLine();

if (anagram.AnagramDetector(first, second))
{
    Console.WriteLine("Given words are Anagrams!");
}
else
{
    Console.WriteLine("No! Given words are not Anagrams!");
}

