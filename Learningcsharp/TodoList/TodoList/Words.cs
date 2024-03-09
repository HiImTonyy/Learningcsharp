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
            Console.WriteLine("Yeah, I didn't bother to continue this. I got a few cool ideas though.");
            Console.Write("Input: ");
            string UserInput = Console.ReadLine();

            if (UserInput.Contains("hello"))
                    {
                Console.WriteLine("Test");
                Console.ReadLine();
                Program.Main();
            }
            else
            {
                Console.WriteLine("Not hello.");
                Console.ReadLine();
                Program.Main();
            }
        }
    }
}
