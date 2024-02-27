using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    internal class Arrays
    {
        public static void ArrayStart()
        {
            /* string[] scamOrdersIDs = new string[3];

            scamOrderIDs[0] = "A555";
            scamOrderIDs[1] = "B008";
            scamOrderIDs[2] = "E333";
            //scamOrderIDs[3] = "E333";

            Console.WriteLine($"First: {scamOrderIDs[0]}");
            Console.WriteLine($"Second: {scamOrderIDs[1]}");
            Console.WriteLine($"Third: {scamOrderIDs[2]}");

            scamOrderIDs[0] = "P000";

            Console.WriteLine($"Re-assigned First: {scamOrderIDs[0]}");
            Console.ReadLine();

            Main(); */

            Console.Clear();
            string[] scamOrderIDs = { "test1", "test2", "test3" };
            string[] scammerNames = { "Rahul", "Aanya", "Sanjay" };
            int[] cashStolen = { 532, 2132, 883, 1029, 433 };

            scamOrderIDs[0] = "blah";
            Console.WriteLine($"Re-assigned First: {scamOrderIDs[0]}");

            Console.WriteLine($"God damn... there are {scamOrderIDs.Length} orders that are complete scams. below are the names of those scammers.\n");
            foreach (string names in scammerNames)
            {
                Console.WriteLine(names);
            }
            Console.WriteLine("\nThat ain't it though, below is the amount of money stolen.\n");

            int cashSum = 0;
            foreach (int cashStole in cashStolen)
            {
                cashSum += cashStole;
            }

            Console.WriteLine($"${cashSum}");
            Console.Read();
        }
    }
}
