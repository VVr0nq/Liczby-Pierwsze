using System;

namespace Program_podajacy_liczby_pierwsze
{
    class Program
    {
        static bool Is_prime(int x)
        {
            for (int a = 2; a < x; a++)
            {
                if (x % a == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers you want?");
            int b;
            b = Convert.ToInt32(Console.ReadLine());
            int[] f = new int[b];
            int c = 2;
            int d = 0;
            int e = 0;
            while (d < b)
            {
                bool pie = Is_prime(c);
                if (pie == true)
                {
                    f[e] = c;
                    e++;
                    c++;
                    d++;
                }
                else
                {
                    c++;
                }
                Console.WriteLine();
                for (int j = 0; j < b; j++)
                {
                    Console.WriteLine(f[j] + " ");
                }
                Console.WriteLine();
            }







        }
    }

}