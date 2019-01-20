using System;
using System.Collections.Generic;
using System.Text;

namespace BilgeAdam.ConvertIssue
{
    class Request
    {
        public string message;
        public static int GetNumber(string message)
        {
            Console.Write(message);
            var value = Console.ReadLine();
            while (true)
            {
                var success = int.TryParse(value, out int number);
                if (success)
                {
                    return number;
                }
                else
                {
                    Console.Write(message);
                    value = Console.ReadLine();
                }
            }
        }
    }
}
