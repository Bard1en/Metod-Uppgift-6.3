using System;
namespace fortnite
{
    class Program
    {
        static void Main(string[] args)
        {
            bool start = true;
            while (start != false) { 
                Console.WriteLine("1. Addera tre tal");
            Console.WriteLine("2. Största talet av två tal");
            Console.WriteLine("3. Avsluta programmet");
            int menyval = int.Parse(Console.ReadLine());
            
            
                switch (menyval)
                {
                    case 1:
                        Console.WriteLine("Skriv in tal 1");
                        int tal1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv in tal 2");
                        int tal2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv in tal 3");
                        int tal3 = int.Parse(Console.ReadLine());
                        Console.WriteLine(MenyvalAddera(tal1, tal2, tal3));
                        break;
                    case 2:
                        Console.WriteLine("Skriv tal 1");
                        int tal4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv in tal 2");
                        int tal5 = int.Parse(Console.ReadLine());
                        Console.WriteLine(MenyvalStörstatalet(tal4, tal5));
                        break;
                    case 3:
                        break;
                }


            }
        }
        static int MenyvalAddera(int tal1, int tal2, int tal3)
        {
            return tal1 + tal2 + tal3;
        }
        static int MenyvalStörstatalet(int tal4, int tal5)
        {
            if (tal4 > tal5)
            {
                return tal4;
            }
            else
            {
                return tal5;
            }
        }
    }
}