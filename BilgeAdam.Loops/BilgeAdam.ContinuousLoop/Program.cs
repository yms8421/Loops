using System;

namespace BilgeAdam.ContinuousLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Kaç Sayı Girilecek.....: ");
                var count = Convert.ToInt16(Console.ReadLine());

                if (count <= 0)
                {
                    break;//Döngüden çık
                }

                var summary = 0;
                for (var i = 0; i < count; i++)
                {
                    Console.Write((i + 1) + ". Sayıyı Giriniz....: ");
                    var number = Convert.ToInt32(Console.ReadLine());
                    if (number <= 0)
                    {
                        continue;
                    }
                    summary += number;
                }

                Console.WriteLine();
                Console.WriteLine("Girilen {0} Adet Sayının Toplamı .....: {1}", count, summary);
                Console.WriteLine();
                Console.WriteLine("Yeni işlem için 'Enter' Tuşuna Basınız");
                Console.ReadLine();
                Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Uygulamadan Çıktınız");
            Console.ReadLine();
        }
    }
}
