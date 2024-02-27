using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    internal class Bool
    {
        public static void BooleanStart()
        {
            Console.Clear();
            /* string value1 = " a";
            string value2 = "A ";
            Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
            Console.Read(); */

            //=============//
            /* Console.WriteLine("a" != "a");
             Console.WriteLine("a" != "A");
             Console.WriteLine(1 != 2); 

             string myValue = "a";
             Console.WriteLine(myValue != "a");
             Console.Read(); */
            //=============//

            /*=============//
            Console.WriteLine(1 > 2);
            Console.WriteLine(1 < 2);
            Console.WriteLine(1 >= 1);
            Console.WriteLine(1 <= 1);

            Console.Read();
           //=============*/

            /* string Words = "15 bucks little man - put that shit in my hand, if that money doesn't show then you owe-me-owe-me-owe-me oh.";
            Console.WriteLine(Words.Contains("15"));
            Console.WriteLine(Words.Contains("Jay"));
            Console.Read(); //// This is getting pretty fucking stupid but it is what it is lol.. 
           //=============*/

            /* string words = ("There is no peace amongst the stars, only an eternity of carnage and slaughter, and the laughter of thirsting gods.\nBut the universe is a big place and, whatever happens, you will not be missed");
            Console.WriteLine(!words.Contains("gods"));
            Console.WriteLine(!words.Contains("Man"));
            Console.Read(); */
            //=============*/

            Console.Clear();
            int saleAmount = 1001;
            int discount = saleAmount > 1000 ? 100 : 50;
            Console.WriteLine($"Discount: {discount}");
            Console.ReadLine();
        }
    }
}
