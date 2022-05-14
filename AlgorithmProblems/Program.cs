// See https://aka.ms/new-console-template for more information
using AlgorithmProblems;

Console.WriteLine("Algorithm Practice Problems!");
while (true)
{
    Console.WriteLine("Please choose the option :\n1) Anagram \n2) Binary Search");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
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
            break;
        case 2:
            BinarySearch bs = new();
            string[] arr = { "apple", "ball", "cat", "dog", "egg", "fish" };
            Console.WriteLine("Please enter a string to be searched :");
            string key = Console.ReadLine();
            int result = bs.binary_search_iterative(arr, key);
            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at "+ "index " + result);
            Console.WriteLine(result);
            break;
        case 3:
            PrimeNumbers p1 = new();
            p1.Prime_Number();
            break;
        default:
            Console.WriteLine("Please choose the correct ");
            break;
    }
}


