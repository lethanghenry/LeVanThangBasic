using System;

namespace Fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập số fibonacci: ");
            int n = int.Parse(Console.ReadLine());
            fibonacci(n);
        }
        //static void fibonacci(int n)
        //{
        //    int f0 = 0;
        //    int f1 = 1;
        //    int fn;
        //    int i;
        //    Console.WriteLine("Dãy fibonacci");
        //    Console.WriteLine(f0);
        //    Console.WriteLine(f1);

        //    for (i = 3; i <= n; i++)
        //    {
        //        fn = f0 + f1;
        //        Console.WriteLine(fn);
        //        f0 = f1;
        //        f1 = fn;
        //    }

        //}


        //static void fibonacci(int n)
        //{
        //    int f0 = 0;
        //    int f1 = 1;
        //    int fn;
        //    int i=3;
        //    Console.WriteLine("Dãy fibonacci");
        //    Console.WriteLine(f0);
        //    Console.WriteLine(f1);

        //    do
        //    {
        //        fn = f0 + f1;
        //        Console.WriteLine(fn);
        //        f0 = f1;
        //        f1 = fn;
        //        i++;
        //    } while (i <= n);

        //}

           static void fibonacci(int n)
        {
            int f0 = 0;
            int f1 = 1;
            int fn;
            int i;

            Console.WriteLine("Dãy fibonacci");
            Console.WriteLine(f0);
            Console.WriteLine(f1);

            for (i = 3; i <= n; i++)
            {
                fn = f0 + f1;
                Console.WriteLine(fn);
                f0 = f1;
                f1 = fn;
            }

        }
    }
}
