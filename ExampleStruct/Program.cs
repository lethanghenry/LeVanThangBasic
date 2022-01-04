using System;

namespace ExampleStruct
{
    struct Books
    {
        public static string Title;
        public static string Author;
        public static string Category;
        public static int BookId;
    }

    struct ToaDo
    {
        public  int x ; 
        public  int y ; 
    }
    class Program
    {

        public static void Main(string[] args)
        {
            //Books book;

            Books.Title = "C# Programming";
            Books.Author = "Trung Nguyên";
            Books.Category = "programming";
            Books.BookId = 6495407;

            Console.WriteLine(Books.Title);
            Console.WriteLine(Books.Author);
            Console.WriteLine(Books.Category);
            Console.WriteLine(Books.BookId);

            ToaDo[] A = new ToaDo[10];  
            for(int i=0;i<A.Length;i++)
            {
                A[i].x = 3;
                A[i].y = 4;
                Console.WriteLine(A[i].x + A[i].y);


            }    
            Console.ReadKey();
        }
    }
}
