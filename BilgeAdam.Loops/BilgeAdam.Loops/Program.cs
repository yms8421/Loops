using System;

namespace BilgeAdam.Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //var a = 3;
            //a = a + 2;
            //a++;
            //a = a + 1;
            //a += 4;
            Console.Write("Kaç Sayı Toplamak İstiyorsunuz?....: ");
            var n = Convert.ToInt32(Console.ReadLine());

            var summary = 0;
            for (var i = 0; i < n; i++)
            {
                Console.Write((i + 1) + ". Sayıyı Giriniz.......: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (number <= 0)
                {
                    continue;//döngüye devam et, değişkeni arttır
                }

                summary += number;
                //100 satır kod
            }

            Console.WriteLine();
            Console.WriteLine("Girilen " + n + " Adet Sayının Toplamı....: " + summary);



            Console.ReadLine();
        }
    }
}
