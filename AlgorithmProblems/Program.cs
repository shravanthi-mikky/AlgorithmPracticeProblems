// See https://aka.ms/new-console-template for more information
using AlgorithmProblems;

Console.WriteLine("Algorithm Practice Problems!");
while (true)
{
    Console.WriteLine("Please choose the option :\n1) Anagram \n2) Binary Search\n3) Prime Numbers Between 0 and 1000\n4) Bubble Sort\n5) Insertion Sort\n6) Merge Sort\n7) Guess the Number\n8) Binary Search Using Generics");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            Anagram anagram = new();
            Console.WriteLine("Please enter the two strings to find if they are anagrams or not. :");
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            if (anagram.AnagramDetector(first, second))
                Console.WriteLine("Given words are Anagrams!");
            else
                Console.WriteLine("No! Given words are not Anagrams!");
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
        case 4:
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Bubble_Sort();
            break;
        case 5:
            InsertionSort sort = new();
            sort.Insertion_Sort();
            break;
        case 6:
            MergeSort merge = new MergeSort();
            int n = 8;
            int[] array = { 49, 3, 53, 21, 27, 75, 50, 41 };
            Console.WriteLine("Merge Sort");
            Console.Write("Initial array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            merge.MergeSort1(array, 0, n - 1);
            Console.Write("\nSorted Array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            break;
        case 7:
            GuessNumber g1 = new();
             g1.Guess();
            break;
        case 8:
            BinarySearchUsingGenerics<int> bs1 = new();
            int[] arr1 = { 10,20,35,40,51,65,78};
            Console.WriteLine("Please enter a number to be searched :");
            int key1 = Convert.ToInt16(Console.ReadLine());
            int result1 = bs1.binary_search_iterative(arr1, key1);
            if (result1 == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at " + "index " + result1);
            Console.WriteLine(result1);
            break;
        default:
            Console.WriteLine("Please choose the correct ");
            break;
    }
}


