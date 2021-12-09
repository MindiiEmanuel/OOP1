using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class ArrayHelper
    {
        public static int[] Fibonacci(int n)
        {
            int[] F = new int[n];
            F[0] = 0;
            if (n == 0) return F;
            F[1] = 1;
            if (n == 1) return F;
            int i = 1;
            while (i < n-1)
            {
                i++;
                F[i] = F[i - 1] + F[i - 2];
            }
            return F;
        }
        public static int Frecventa(int[] vector, int element)
        {
            int frecventa = 0;
            for (int i = 0; i <= vector.Length; i++)
            {
                if (vector[i] == element) frecventa++;
            }
            return frecventa;
        }
    }
}
