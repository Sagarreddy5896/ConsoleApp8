using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    static class LengthString
    {
        public static void Tocurrency(this String S, string value)
        {
                if (int.TryParse(value, out var i))
                {
                    Console.WriteLine("$" + value);
                }
                else
                {
                    Console.WriteLine("Enter String as numeric");
                }
         
            
        }
    }
}
