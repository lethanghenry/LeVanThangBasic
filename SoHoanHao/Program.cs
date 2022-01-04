using System;
using System.Collections.Generic;

namespace SoHoanHao
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("nhập số cần kiểm tra: ");
            int n = int.Parse(Console.ReadLine());
            if(HoanHao(n))
            {
                Console.WriteLine(n + "là số hoàn hảo");
            }
            else
            {
                Console.WriteLine(n + "Không phải là số hoàn hảo");
            }
        }

        //static bool HoanHao(int n)
        //{
        //    int sum = 0;
        //    for (int i = 1; i < n; i++)
        //    {
        //        if (n % i == 0)
        //        {
        //            sum += i;
        //        }
        //    }
        //    if (sum == n) return true;
        //    if (sum != n) return false;
        //    return false;
        //}

        //static bool HoanHao(int n)
        //{
        //    int sum = 0;
        //    int i = 1;
        //    do
        //    {

        //        if (n % i == 0)
        //        {
        //            sum += i;
        //        }
        //        i++;
        //    } while (i < n);
        //    if (sum == n) return true;
        //    if (sum != n) return false;
        //    return false;

        //}
        static bool HoanHao(int n)
        {
            int sum = 0;
            List<int> a = new List<int>();
            for(int i=1;i<n;i++)
            {
                a.Add(i);
            }    
            foreach(var item in a)
            {
                if(n%item==0)
                {
                    sum += item;
                }    
            }
            if (sum == n) return true;
            if (sum != n) return false;
            return false;
        }

    }
}
