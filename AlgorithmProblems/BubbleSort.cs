using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    public class BubbleSort
    {
       
        public void Bubble_Sort()
        {
            List<int> list = new List<int>() { 5, 2, 6, 9, 1 };
            int temp;
            Console.WriteLine("The original elements are:");
            foreach (int a in list)
                Console.Write(a + " ");
            Console.WriteLine();
            for (int j = 0; j <= list.Count - 2; j++)
            {
                for (int i = 0; i <= list.Count - 2; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        temp = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = temp;
                    }
                }
            }
            Console.WriteLine("The bubble sorted elements are:");
            foreach (int p in list)
                Console.Write(p + " ");
            Console.WriteLine();
        }
    }
}
