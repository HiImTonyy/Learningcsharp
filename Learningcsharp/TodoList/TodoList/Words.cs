using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    internal class Words
    {
        public static void WordsStart()
        {
            Console.Write("Input: ");
            string UserInput = Console.ReadLine();

            if (UserInput.Contains("hello"))
                    {
                Console.WriteLine("Test");
                Console.ReadLine();
                WordsStart();
            }
            else
            {
                Console.WriteLine("Not hello.");
                Console.ReadLine();
                WordsStart();
            }
        }
    }
}
