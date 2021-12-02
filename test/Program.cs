using System;
using System.Collections.Generic;

namespace test
{

    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.Read());
            }
            for (int i = 0; i < n; i++)
            {
                arr2[i] = arr[i] / 2;
                while (arr2[i] != 0 && arr2[i] % 2 == 0)
                {
                    arr2[i] /= 2;
                }
            }

            var h = new HashSet<int>(arr2);
            int m = h.Count;
            Console.WriteLine(m);
            

        }
    }
}
