using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ins_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] X = { 1000, 2,56,912, 231, 501, 599, 600, 40, 50, 780, 70, 3, 80, 90, 850, 120, 130, 140, 150, 300,
                351, 2, 400, 453, 10, 20, 30, 675, 60, 790, 800, 100, 900, 942, 950, 1 };
            int j;
            int temp;

            for (int i = 1; i < X.Length; i++)
            {
                j = i - 1;

                while (j >= 0 && X[j] > X[j + 1])
                {

                    temp = X[j];
                    X[j] = X[j + 1];
                    X[j + 1] = temp;

                    j = j - 1;

                }

            }

            for (int i = 0; i < X.Length; i++)
            {
                Console.WriteLine(X[i]);
            }

            Console.ReadKey();






        }
    }
}
