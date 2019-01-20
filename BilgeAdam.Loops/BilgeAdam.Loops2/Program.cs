using System;

namespace BilgeAdam.Loops2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 0;
            
            while (a < 10)//true yazarsam hep çalışır hiç durmaz
            {
                Console.WriteLine(++a + " Defa Çalıştım");
            }
            Console.ReadLine();
        }
    }
}
