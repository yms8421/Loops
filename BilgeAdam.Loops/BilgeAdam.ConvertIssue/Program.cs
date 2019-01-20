using System;

namespace BilgeAdam.ConvertIssue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bu iki satırı dikkate almayın
            var re = new Request();
            re.message = "Bu mesajı dikkate almayın"; //message field'ı static olmadığı için "new" anahtar kelimesiyle üretilmiş class a ihtiyaç duyar


            while (true)
            {
                var count = Request.GetNumber("Kaç Sayı Girilecek.....: ");
                //GetNumber static olduğu için "new" anahtar kelimesiyle üretilmiş class'a ihtiyaç duymaz 
                if (count <= 0)
                {
                    break;//Döngüden çık
                }

                var summary = 0;
                for (var i = 0; i < count; i++)
                {
                    var number = Request.GetNumber((i + 1) + ". Sayıyı Giriniz....: ");
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
