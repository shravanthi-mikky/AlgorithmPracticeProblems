﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    public class PrimeNumbers
    {
        public void Prime_Number()
        {
            Console.WriteLine("Enter the Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime Numbers between 0 and 1000 are :");
            for(int j = 2; j <= number; j++)
            {
                int count = 0;
                for (int i = 2; i <= j/2 ; i++)
                {
                    if ((j % i) == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0 )
                    Console.Write(j +" ");
            }
        }

    }
}
