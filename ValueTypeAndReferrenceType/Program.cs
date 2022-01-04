using System;

namespace ValueTypeAndReferrenceType
{
    class Program
    {
        /// <summary>
        /// Test Out
        /// </summary>
        /// <param name="value"></param>
        static void TestOut(out int value)

        {
            value = 0;
            value++;
        }

        /// <summary>
        /// Test Ref
        /// </summary>
        /// <param name="value"></param>
        static void TestRef(ref int value)

        {
            value++;
        }

        [Flags]
        public enum MyDays
        {
            None = 0,
            Sunday = 1,
            Monday = 2,
            Tuesday = 4,
            Wednesday = 8,
            Thursday = 16,
            Friday = 32,
            Saturday = 64
        }
        public

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int x;
            x = 5;

            string str1;
            str1 = "Hello there";

            int a;
            a = 1;
            int b;
            b = a;
            a++;

            string str2;
            str2 = "thang";
            string str3;
            str3 = str2;

            // Bài Tập
            int value = 5;
            TestOut(out value);
            Console.WriteLine(value);
            TestRef(ref value);
            Console.WriteLine(value);

            //

            var today = MyDays.Wednesday;
            Console.WriteLine(today);
            //
            var mondayOrTuesday = MyDays.Monday | MyDays.Tuesday;
            Console.WriteLine(mondayOrTuesday);
        }
    }
}
