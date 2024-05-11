using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace LearningCSharpRemastered
{
    internal class Logicfile
    {
        public static bool methodInfoGoBack = false;
        public static void MethodInfo()
        {
            while (true)
            {
                int inputNumber;
                string selectedInfoNumber;

                Console.ForegroundColor = ConsoleColor.DarkCyan;

                Console.WriteLine("\nType in the task number to check the info.\n");

                string input = Console.ReadLine();
                int.TryParse(input, out inputNumber);

                List<string> infolist = new List<string>();
                {
                    infolist.Add("Create a new Hello World program. (yeah, that's it.)\nThe next part is to change 'Hello World' to something else. I already did that, so.. it is what it is.");
                    infolist.Add("Make a program with 5 Console.WriteLine statements in it.");
                    infolist.Add("Bread is ready.\nWho is the bread for?\n(user enters RB)\nNoted:RB got bread.\n\nMake a program that runs as shown above, including taking a name from the user.");
                    infolist.Add("Rebuild the program.\nAdd comments near each of the four variables that describe what they store. You must use at least each one of each cooment type.\nFind the bug in the text displayed and fix it.");
                    infolist.Add("Build a program with a variable of all 14 types.\nAssign each of them a value using a literal of the correct type.\nUse Console.WriteLine to display the contents of each variable\nThe next part is changing the variables to something else without declaring any additional variables.");
                    infolist.Add("AREA = BASE X HEIGHT / 2\n\nWrite a program that lets you input the triangles base size and height.\nCompute the area of a triangle by turning the above equation into code.\nWrite the result of the computation.");
                    infolist.Add("Create a program that lets the user enter the number of chocolate eggs gathered that day.\nUsing / and %, compute how many eggs each sister should get and how many are left over for the duckbear. (there are 3 sisters)\n");
                    infolist.Add("Create a program that allows users to enter how many provinces, duchies, and estates they have.\nAdd up the user’s total score, giving 1 point per estate, 3 per duchy, and 6 per province.\nDisplay the point total to the user.");
                    infolist.Add("Ask the user for the target row and column.\nCompute the neighboring rows and columns of where to deploy the squad.\nDisplay the deployment instructions in a different color of your choosing.\nChange the window title to be “Defense of Consolas”.\nPlay a sound with Console.Beep when the results have been computed and displayed.");
                    infolist.Add("Take a number as input from the console.\nDisplay the word “Tick” if the number is even. Display the word “Tock” if the number is odd.");
                    infolist.Add("Ask the user for an x value and a y value. These are coordinates of the enemy relative to the watchtower’s location.\nUsing the image provided, write if statements and relational operators, and also display a message about what direction the enemy is coming from.");
                    infolist.Add("Build a program that will show a menu.\nAsk the user to enter number from the menu.\nMust use switches.\n(The next part is to ask for the name and if the user types in my name, then cut the price by half. I just did it all in 1)");
                    infolist.Add("Build a program that will allow a user, the pilot,to enter a number.\nIf the number is above 100 or less than 0, keep asking.\nClear the screen once the program has collected a good number.\nAsk a second user, the hunter,to guess numbers.\nIndicate whether the user guessed too high, too low, or guessed right\nLoop until they get it right, then end the program.");
                    infolist.Add("Write a program that will loop through the values between 1 and 100 and display what kind of blast the crew should expect.\nChange the color of the output based on the type of blast.\n(I decided to make it loop to however many numbers you want instead of looping to just 100.)");
                    infolist.Add("Make a program that creates an array of length 5.\nAsk the user for five numbers and put them in the array.\nMake a second array of length 5.Use a loop to copy the values out of the original array and into the new one.\nDisplay the contents of both arrays one at a time.");
                    infolist.Add("Start with the code that computes an array’s minimum and average values.\nModify the code to use foreach loops instead of for loops\n(you'll have to look at the actual code to see the difference)");
                    infolist.Add("Make a method with the signature int AskForNumber(string text). Display the text parameter in the console window, get a response from the user, convert it to an int, and return it.\nMake a method with the signature int AskForNumberInRange(string text, int min, int max). Only return if the entered number is between the min and max values. Otherwise, ask again.");
                    infolist.Add("Write code that counts down from 10 to 1 using a recursive method.");
                    infolist.Add("Establish the game’s starting state: the Manticore begins with 10 health points and the city with 15. The game starts at round 1.\nAsk the first player to choose the Manticore’s distance from the city (0 to 100). Clear the screen afterward.\nRun the game in a loop until either the Manticore’s or city’s health reaches 0.\nBefore the second player’s turn, display the round number, the city’s health, and the Manticore’s health.\nCompute how much damage the cannon will deal this round: 10 points if the round number is a\r\nmultiple of both 3 and 5, 3 if it is a multiple of 3 or 5 (but not both), and 1 otherwise. Display this to the player.\nGet a target range from the second player, and resolve its effect. Tell the user if they overshot (too\r\nfar), fell short, or hit the Manticore. If it was a hit, reduce the Manticore’s health by the expected amount.\nIf the Manticore is still alive, reduce the city’s health by 1.\nAdvance to the next round.\nWhen the Manticore or the city’s health reaches 0, end the game and display the outcome\nUse different colors for different types of messages.");
                    infolist.Add("Define an enumeration for the state of the chest.\nMake a variable whose type is this new enumeration.\nWrite code to allow you to manipulate the chest with the lock, unlock, open, and close\r\ncommands, but ensure that you don’t transition between states that don’t support it.\nLoop forever, asking for the next command.");
                    infolist.Add("Define enumerations for the three variations on food: type (soup, stew, gumbo), main ingredient (mushrooms, chicken, carrots, potatoes), and seasoning (spicy, salty, sweet).\nMake a tuple variable to represent a soup composed of the three above enumeration types.\nLet the user pick a type, main ingredient, and seasoning from the allowed choices and fill the tuple with the results.\nWhen done, display the contents of the soup tuple variable in a format like “Sweet Chicken Gumbo.");
                    infolist.Add("Define a new Arrow class with fields for arrowhead type, fletching type, and length.\nAllow a user to pick the arrowhead, fletching type, and length and then create a new Arrow instance.\nAdd a GetCost method that returns its cost as a float based on the numbers above, and use this to display the arrow’s cost.\nThe other part is to make the variables private while also making them avalible outside of the class.\nThe part after that one is to make it use properties.\n...And the one after THAT one is to create pre-made arrows using static methods.");
                    infolist.Add("Define a new Point class with properties for X and Y.\nAdd a constructor to create a point from a specific x- and y-coordinate.\nAdd a parameterless constructor to create a point at the origin (0, 0).\nIn your main method, create a point at (2, 3) and another at (-4, 0). Display these points on the console window in the format (x, y) to illustrate that the class works.");
                    infolist.Add("Define a new Color class with properties for its red, green, and blue channels.\nAdd appropriate constructors that you feel make sense for creating new Color objects.\nCreate static properties to define the eight commonly used colors for easy access.\nn your main method, make two Color-typed variables. Use a constructor to create a color instance\r\nand use a static property for the other. Display each of their red, green, and blue channel values.");
                };

                if (inputNumber >= infolist.Count || inputNumber < 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("We don't have that number. press enter if you understand.");
                    Console.ReadLine();
                    Console.ResetColor();
                    methodInfoGoBack = true;
                    Program.Main();
                }
                else
                {
                    selectedInfoNumber = infolist[inputNumber];

                    Console.ForegroundColor = ConsoleColor.Magenta;

                    Console.WriteLine("************************************************************************************************************************************************************************************");
                    Console.WriteLine($"OBJECTIVE(S):\n\n{selectedInfoNumber}\n");
                    Console.WriteLine("************************************************************************************************************************************************************************************\n");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkCyan;

                    Console.WriteLine("Would you like to check out a different task?\n");

                    Console.WriteLine("1) Yes");
                    Console.WriteLine("2) No");

                    input = Console.ReadLine();

                    if (input == "1")
                    {
                        methodInfoGoBack = true;
                        Program.Main();
                    }
                    else if (input == "2")
                    {
                        Console.ResetColor();
                        methodInfoGoBack = false;
                        Program.Main();
                    }
                    else
                    {
                        InvalidInput();
                        methodInfoGoBack = true;
                        Program.Main();
                    }
                }
            }
        }

        public static string selectedInsult;
        public static string selectedInsultWord;
        public static void InvalidInput()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            List<string> insultList = new List<string>();
            {
                insultList.Add("Are you retarded? we don't have that input!");
                insultList.Add("Do we have that input? ... NO YOU F*CKING MORON!");
                insultList.Add("WE. DO. NOT. HAVE. THAT. INPUT.");
                insultList.Add("Are you blind? there is no input for that!");
                insultList.Add("LOOK ON THE SCREEN. THERE IS NO INPUT FOR THAT!");
                insultList.Add("Yo, you trippin'? cuz we don't got that input!");
                insultList.Add("Wrong input, please try again - or don't, because you don't know how to read clearly.");
                insultList.Add("Hot damn! we don't have an input for that, try again!");
                insultList.Add("Holy. S*IT. DO YOU NOT KNOW HOW TO READ!? WRONG INPUT, TRY AGAIN!");
                insultList.Add("If you type in the wrong input again, I'll find you and BREAK YOU. TRY AGAIN.");
                insultList.Add("Did your Momma ever teach how to read? WRONG F*CKING INPUT!");
                insultList.Add("WRRROONNG INNNNNPPPPUUUUUUUUUUUTTTTTTTTTTTTTTTTTTTTT.");
                insultList.Add("NO NO NO NO NO. WE HAVE NO GOD DAMN INPUTS FOR THAT!");
            };
            List<string> insultWordList = new List<string>();
            {
                insultWordList.Add("bozo");
                insultWordList.Add("dimwit");
                insultWordList.Add("idiot");
                insultWordList.Add("dumbass");
                insultWordList.Add("retard");
                insultWordList.Add("asshat");
                insultWordList.Add("spastic");
                insultWordList.Add("cunt");
                insultWordList.Add("disappointment");
                insultWordList.Add("mistake");
                insultWordList.Add("fucknut");
                insultWordList.Add("pigdog");
                insultWordList.Add("fucktard");
                insultWordList.Add("wanker");
                insultWordList.Add("dingus");
                insultWordList.Add("pissant");
                insultWordList.Add("shithead");
                insultWordList.Add("dickbutt");
                insultWordList.Add("twatbasket");
                insultWordList.Add("meatball");
                insultWordList.Add("dirtbag");
                insultWordList.Add("asswipe");
                insultWordList.Add("moron");
                insultWordList.Add("douchenozzle");
                insultWordList.Add("idget");
                insultWordList.Add("douchewagon");
                insultWordList.Add("slut");
                insultWordList.Add("dickwaffle");
                insultWordList.Add("wafflecunt");
                insultWordList.Add("dickbag");
                insultWordList.Add("weiner");
                insultWordList.Add("dink");
                insultWordList.Add("srub");
                insultWordList.Add("dickweed");
                insultWordList.Add("loser");
                insultWordList.Add("knobhead");
                insultWordList.Add("slutsaurus");
                insultWordList.Add("rat");
                insultWordList.Add("assclown");
                insultWordList.Add("dickbreath");
                insultWordList.Add("turd");
                insultWordList.Add("ballwasher");
                insultWordList.Add("dicknugget");
                insultWordList.Add("fucknugget");
                insultWordList.Add("assgoblin");
                insultWordList.Add("dumbfuck");
            };

            Random rando = new Random();
            Random randoWord = new Random();

            int selector = rando.Next(insultList.Count);
            int selectorInsultWord = rando.Next(insultWordList.Count);

            selectedInsult = insultList[selector];
            selectedInsultWord = insultWordList[selectorInsultWord];

            Console.WriteLine($"\n{selectedInsult}\n");
            Console.WriteLine($"Press enter if you understand... you {selectedInsultWord}.");
            Console.ReadLine();
            Console.ResetColor();
            Console.Clear();
        }

        public static void EndMethodNotice()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n*************************************************************");
            Console.WriteLine("*** End of task. please press enter to exit current task. ***");
            Console.WriteLine("*************************************************************");
            Console.ReadLine();
            Console.ResetColor();
            Program.Main();
        }

        public static void GoAgainNotice()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int result = Logicfile.AskForNumber("\nWould you like to go again?\n1) Yes\n2) No");

            if (result == 1) Console.ResetColor();
            else Program.Main();
        }

        public static int AskForNumber(string text)
        {
            while (true)
            {
                int number;

                Console.WriteLine($"{text}\n");

                string stringNumber = Console.ReadLine();

                bool isString =! int.TryParse(stringNumber, out number);

                if (isString)
                {
                    Logicfile.InvalidInput();
                }
                else
                {
                    Console.Clear();
                    return number;
                }
            }
        }

        public enum Treasure {open, closed, locked, unlocked}
        public enum EnumType {soup = 1, stew, gumbo}
        public enum EnumIngredient {mushroom = 1, chicken, carrots, potatos}
        public enum EnumSeasoning { Spicy = 1, Salty, Sweet}
    }
}

/* Random notes I guess
 * 
 * class Space 
 * {

   private int size;

   public Space()
  {
   size = 0;
  }

   public void Expand() 
    {
     size += 1;
    }

  }
=======================================
class Main {

public static void main
{

Space largeSpace = new Space();

// Space is 0 because of constructor

largeSpace.Expand();

// largeSpace size is 1
*/