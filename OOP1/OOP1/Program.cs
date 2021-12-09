using System;

namespace OOP1
{
    class Program
    {
        public static void Main(string[] args)
        {
           int n;
            n = Int32.Parse(Console.ReadLine());
           int[] vector = ArrayHelper.Fibonacci(n);
            for (int i = 0; i < vector.Length; i++)
                Console.WriteLine(vector[i] + " ");
            n = Int32.Parse(Console.ReadLine());
            int[] v = new int[n];

            int nr = Int32.Parse(Console.ReadLine());
            int[] vector1 = new int[nr];

            for (int i = 0; i < nr; i++)
            {
                Console.WriteLine($"vector1[{i}]");
                vector1[i] = Int32.Parse(Console.ReadLine());

            }
            int element = Int32.Parse(Console.ReadLine());

            Console.WriteLine(ArrayHelper.Frecventa(vector1, element));


            Console.WriteLine("Introduceti numarul de linii!");

            int n1 = Int32.Parse(Console.ReadLine());
            int[,] matrix = new int[n1, n1];
        }
    }
}
