using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace TodoList
{
    internal class Arrays
    {
        public static void ArrayStart()
        {
            Console.Clear();
            Console.WriteLine("1) First Arrays");
            Console.WriteLine("2) Second Arrays");
            Console.WriteLine("3) Third Arrays");
            Console.WriteLine("4) Back to previous program");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Array1();
                    break;

                case "2":
                    Array2();
                    break;

                case "3":
                    Array3();
                    break;

                case "4":
                    Program.Main();
                    break;

                default:
                    ArrayStart();
                    break;
            }
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

            static void Array1()
            {
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
                Console.ReadLine();
                ArrayStart();
            }

            static void Array2()
            {
                Console.Clear();
                int examAssignments = 5;

                int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
                int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
                int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
                int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

                string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

                int[] studentScores = new int[10];

                string currentStudentLetterGrade = "";

                Console.WriteLine("Student\t\tGrade\n");

                foreach (string name in studentNames)
                {
                    string currentStudent = name;

                    if (currentStudent == "Sophia")
                        studentScores = sophiaScores;

                    else if (currentStudent == "Andrew")
                        studentScores = andrewScores;

                    else if (currentStudent == "Emma")
                        studentScores = emmaScores;

                    else if (currentStudent == "Logan")
                        studentScores = loganScores;

                    int sumAssignmentScores = 0;

                    decimal currentStudentGrade = 0;

                    int gradedAssignments = 0;

                    foreach (int score in studentScores)
                    {
                        gradedAssignments += 1;

                        if (gradedAssignments <= examAssignments)
                            sumAssignmentScores += score;

                        else
                            sumAssignmentScores += score / 10;
                    }

                    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

                    if (currentStudentGrade >= 97)
                        currentStudentLetterGrade = "A+";

                    else if (currentStudentGrade >= 93)
                        currentStudentLetterGrade = "A";

                    else if (currentStudentGrade >= 90)
                        currentStudentLetterGrade = "A-";

                    else if (currentStudentGrade >= 87)
                        currentStudentLetterGrade = "B+";

                    else if (currentStudentGrade >= 83)
                        currentStudentLetterGrade = "B";

                    else if (currentStudentGrade >= 80)
                        currentStudentLetterGrade = "B-";

                    else if (currentStudentGrade >= 77)
                        currentStudentLetterGrade = "C+";

                    else if (currentStudentGrade >= 73)
                        currentStudentLetterGrade = "C";

                    else if (currentStudentGrade >= 70)
                        currentStudentLetterGrade = "C-";

                    else if (currentStudentGrade >= 67)
                        currentStudentLetterGrade = "D+";

                    else if (currentStudentGrade >= 63)
                        currentStudentLetterGrade = "D";

                    else if (currentStudentGrade >= 60)
                        currentStudentLetterGrade = "D-";

                    else
                        currentStudentLetterGrade = "F";

                    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
                }

                Console.ReadLine();
            }
            static void Array3()
            {
                string[,] creatureNames = new string[2, 2] { {"Klagson", "Lefojalk"},
                    {"It knows much, but not of pain or fear.", "A monstrous creature the size of a small planet. its very dociele, but still feeds on everything that gets in its way." } };
                Console.WriteLine("Creature: {0}",
                creatureNames.GetValue(1, 0));
                Console.ReadLine();
            }
        }
    }
}
