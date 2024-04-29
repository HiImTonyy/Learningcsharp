using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharpRemastered
{
    internal class Games
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1) Typing Test");

            string input = Console.ReadLine();
            Console.Clear();

            switch (input)
            {
                case "1":
                    TypingTest();
                    break;
            }
        }

        static void TypingTest()
        {
            Console.WriteLine("How hard do you want the words to be?\n");

            Console.WriteLine("1) Easy");
            Console.WriteLine("2) Medium");
            Console.WriteLine("3) Hard");
            Console.WriteLine("4) Godlike");

            string input = Console.ReadLine();
        }
    }
}
