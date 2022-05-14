using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    public class PrimeAnagramPalindrome
    {
        public List<int> Prime_Number()
        {
            List<int> primeNumbers = new List<int>();
            int number = 1000;
            for (int j = 2; j <= number; j++)
            {
                int count = 0;
                for (int i = 2; i <= j / 2; i++)
                {
                    if ((j % i) == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    primeNumbers.Append(j);
                }
            }
            return primeNumbers;
        }
        public void palindrome(List<int> primeNumbers)
        {
            for(int i = 0; i < primeNumbers.Count; i++)
            {
                int r, sum = 0;
                int n = primeNumbers[i];
                while (n > 0)
                {
                    r = n % 10;
                    sum = (sum * 10) + r;
                    n = n / 10;
                }
                if (primeNumbers[i] == sum)
                    Console.Write("Number is Palindrome.");
                else
                    Console.Write("Number is not Palindrome");
            }
            
        }
    }
}
