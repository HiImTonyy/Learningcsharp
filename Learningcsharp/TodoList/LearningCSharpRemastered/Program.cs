using LearningCSharpRemastered;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main()
    {
        Console.Title = "LearningCSharpRemastered: Electric Boogaloo part LXIX";
        Logicfile instance = new Logicfile();
        while (true)
        {
            Console.ResetColor();
            Console.Clear();
            Console.SetWindowSize(180, 51);
            Console.WriteLine("Hey dude, what task do you wanna check out?");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("NOTE: If you want to know the objective / info of any given task, then type in 'info'.\n");
            Console.ResetColor();

            Console.WriteLine("0) Hello World! + Changing the text");
            Console.WriteLine("1) Multiple Statements");
            Console.WriteLine("2) Taking user-input and using it");
            Console.WriteLine("3) Comments and fixing bugs");
            Console.WriteLine("4) Assigning all variable types + Changing the variables");
            Console.WriteLine("5) Calculating the area of a traingle");
            Console.WriteLine("6) Using the % operator to figure out the remainder of X");
            Console.WriteLine("7) Incrementing X amount based on X amount");
            Console.WriteLine("8) Target X column and X Row");
            Console.WriteLine("9) If X is even write Tick, otherwise write odd.");
            Console.WriteLine("10) Ask for Y and X to corrispond with position");
            Console.WriteLine("11) The Shop Menu");
            Console.WriteLine("12) Guessing number with loop");
            Console.WriteLine("13) The Magic Cannon (using a loop and remainder)"); // no idea what to call this one.
            Console.WriteLine("14) Using an array and copying user input into another array.");
            Console.WriteLine("15) Change for loop to foreach loop.");
            Console.WriteLine("16) Working with parameters");
            Console.WriteLine("17) Counting down from 10 using Recursive Method");
            Console.WriteLine("18) (Boss) Hunting the Manticore");
            Console.WriteLine("19) Using Enums to switch between states");
            Console.WriteLine("20) Tuple Soup");
            Console.WriteLine("21) Using fields to create different Arrows\n");

            Console.ResetColor();
            if (Logicfile.methodInfoGoBack)
                Logicfile.MethodInfo();
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "0":
                    HelloWorld();
                    break;
                case "1":
                    MultipleLines();
                    break;
                case "2":
                    UserInput();
                    break;
                case "3":
                    CommentBugs();
                    break;
                case "4":
                    VariableTypes();
                    break;
                case "5":
                    Triangle();
                    break;
                case "6":
                    Remainder();
                    break;
                case "7":
                    ThreeKings();
                    break;
                case "8":
                    TheDefense();
                    break;
                case "9":
                    TickTock();
                    break;
                case "10":
                    Watchtower();
                    break;
                case "11":
                    TheShop();
                    break;
                case "12":
                    Loops();
                    break;
                case "13":
                    MagicCannon();
                    break;
                case "14":
                    AnArray();
                    break;
                case "15":
                    ForEach();
                    break;
                case "16":
                    NumberTest();
                    break;
                case "17":
                    Recursive();
                    break;
                case "18":
                    TheManticore();
                    break;
                case "19":
                    EnumStates();
                    break;
                case "20":
                    TupleSoup();
                    break;
                case "21":
                    Arrows();
                    break;

                case "info":
                    Logicfile.MethodInfo();
                    break;

                default:
                    Logicfile.InvalidInput();
                    break;
            }
        }
    }

    static void HelloWorld()
    {
        Console.Clear();
        Console.WriteLine("\"The road to hell is paved with good intentions and the ones you love litter the road-side.\"");
        Logicfile.EndMethodNotice();
    }

    static void MultipleLines()
    {
        Console.Clear();
        Console.WriteLine("This hardcore ghetto gangster image takes a lot of practice");
        Console.WriteLine("I'm not black like Barry White, no, I am white like Frank Black is");
        Console.WriteLine("So, if man is five and the devil is six, then that must make me seven");
        Console.WriteLine("This honkey's gone to heaven");
        Console.WriteLine("But if I go to hell, well, then I hope I burn well.");
        Logicfile.EndMethodNotice();
    }

    static void UserInput()
    {
        string person;
        Console.Clear();
        Console.WriteLine("Bread is ready.");
        Console.WriteLine("Who is the bread for?");
        person = Console.ReadLine();
        Console.WriteLine("Noted: " + person + " got bread.");
        Logicfile.EndMethodNotice();
    }

    static void CommentBugs()
    {
        Console.Clear();
        string code = @"
Console.WriteLine(""What kind of thing are we talking about?"");
string a = Console.ReadLine(); 
Console.WriteLine(""How would you describe it? Big? Azure? Tattered?"");
string b = Console.ReadLine();
string c = ""of Doom"";
string d = ""3000"";
Console.WriteLine(""The "" + b + "" "" + a + "" of "" + c + "" "" + d + ""!"");";

        string code2 = @"
Console.WriteLine(""What kind of thing are we talking about?"");
string a = Console.ReadLine();  // a is whatever the user types in. it is the ""thing"". 
Console.WriteLine(""How would you describe it? Big? Azure? Tattered?"");
string b = Console.ReadLine(); // b is what the user describes. 
string c = ""of Doom""; // c is the string to be placed near the end of the WriteLine. 
string d = ""3000"";    // The last string to be placed in the WriteLine.
Console.WriteLine(""The "" + a + "" "" + b + "" of "" + c + "" "" + d + ""!"");
/*
 * These comments are kinda shit, but I mean.. there isn't a whole lot to work with. comments are meant for seemingly complex things, but I understand that they are useful. 
 */";

        // The bug was the word of inside string c.

        Console.WriteLine("BEFORE");
        Console.WriteLine("======");
        Console.WriteLine(code + "\n");

        Console.WriteLine("AFTER");
        Console.WriteLine("======");
        Console.WriteLine(code2);

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\nNOTE: You'll need to look at the actual code to see more clearly, but.. it is what it is. I didn't need to show all the code here, but I did anyways.");
        Console.ResetColor();

        Console.WriteLine("\nPress enter to continue...");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("What kind of thing are we talking about?");
        string a = Console.ReadLine();  // String a is whatever the user types in. it is the "thing". 
        Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
        string b = Console.ReadLine(); // String b is what the user describes. 
        string c = "Doom"; // String c is the string to be placed near the end of the WriteLine. 
        string d = "3000";    // String d is the last string to be placed in the WriteLine.
        Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");
        /*
         * These comments are kinda shit, but I mean.. there isn't a whole lot to work with. comments are meant for seemingly complex things, but I understand that they are useful. 
         */

        Logicfile.EndMethodNotice();
    }

    static void VariableTypes()
    {
        Console.Clear();
        char aChar = 'a';
        string aString = "whatever";
        sbyte aSbyte = 10;
        byte aByte = 1;
        short aShort = -100;
        ushort aUshort = 25;
        int aInt = 25_000;
        uint aUint = 150_000;
        long aLong = 25_000_000;
        ulong aUlong = 1_000_000_000_000;
        float aFloat = 25.1f;
        double aDouble = 25000.12;
        decimal aDecmial = 99.220000m;
        bool aBool = true;

        Console.WriteLine("Char: " + aChar);
        Console.WriteLine("String: " + aString);
        Console.WriteLine("Sbyte: " + aSbyte);
        Console.WriteLine("Byte: " + aByte);
        Console.WriteLine("Short: " + aShort);
        Console.WriteLine("Ushort: " + aUshort);
        Console.WriteLine("Int: " + aInt);
        Console.WriteLine("Uint: " + aUint);
        Console.WriteLine("Long: " + aLong);
        Console.WriteLine("Ulong: " + aUlong);
        Console.WriteLine("Float: " + aFloat);
        Console.WriteLine("Double: " + aDouble);
        Console.WriteLine("Decimal: " + aDecmial);
        Console.WriteLine("Bool: " + aBool);

        Console.WriteLine("\nPress enter to continue...");
        Console.ReadLine();

        aChar = 'z';
        aString = "Nothin' like drinking a large triple-triple from Tim Hortons and eating a Breakfest-sausage bagle at 3AM";
        aSbyte = 000;
        aByte = 98;
        aShort = -9010;
        aUshort = 1895;
        aInt = 195_000;
        aUint = 830_140;
        aLong = 75_010_230;
        aUlong = 10_203_050_100_000;
        aFloat = 165.5f;
        aDouble = 200.91;
        aDecmial = 1099.1927830m;
        aBool = false;

        Console.WriteLine("Char: " + aChar);
        Console.WriteLine("String: " + aString);
        Console.WriteLine("Sbyte: " + aSbyte);
        Console.WriteLine("Byte: " + aByte);
        Console.WriteLine("Short: " + aShort);
        Console.WriteLine("Ushort: " + aUshort);
        Console.WriteLine("Int: " + aInt);
        Console.WriteLine("Uint: " + aUint);
        Console.WriteLine("Long: " + aLong);
        Console.WriteLine("Ulong: " + aUlong);
        Console.WriteLine("Float: " + aFloat);
        Console.WriteLine("Double: " + aDouble);
        Console.WriteLine("Decimal: " + aDecmial);
        Console.WriteLine("Bool: " + aBool);
        Logicfile.EndMethodNotice();
    }

    static void Triangle()
    {
        while (true)
        {
            Console.Clear();
            float triangleArea;
            int triangleBase;
            int triangleHeight;

            triangleBase = Logicfile.AskForNumber("Enter the base of the triangle.");

            Console.Clear();
            triangleHeight = Logicfile.AskForNumber("Now type in the height of your traingle.");

            Console.Clear();
            triangleArea = (triangleBase * triangleHeight) / 2f;
            Console.WriteLine(triangleBase + " * " + triangleHeight + " / 2 = " + triangleArea);
            Console.WriteLine("So the area of the traingle is " + triangleArea);
            Logicfile.GoAgainNotice();
        }
    }

    static void Remainder()
    {
        while (true)
        {
            int eggsCollected;
            int eggsRemainder;
            int sistersEggCount;

            Console.Clear();
            eggsCollected = Logicfile.AskForNumber("How many eggs did you collect today?");

            sistersEggCount = eggsCollected / 3;
            eggsRemainder = eggsCollected % 3;


            Console.WriteLine("You collected " + eggsCollected);
            Console.WriteLine("Each of the 3 sisters will recieve " + sistersEggCount);
            Console.WriteLine("The remainder is " + eggsRemainder + ". So their pet will just recieve " + eggsRemainder);
            Logicfile.GoAgainNotice();
        }
    }

    static void ThreeKings()
    {
        while (true)
        {
            int estateAmount;
            int duchyAmount;
            int provinceAmount;
            int duchyPoints;
            int provincePoints;
            int totalPoints;

            Console.Clear();
            estateAmount = Logicfile.AskForNumber("How many Estates do you have?");

            duchyAmount = Logicfile.AskForNumber("How many Duchies do you have?");
            duchyPoints = duchyAmount * 3;

            provinceAmount = Logicfile.AskForNumber("How many Provinces do you have?");
            provincePoints = provinceAmount * 6;

            totalPoints = provincePoints + duchyPoints + estateAmount;

            Console.Clear();
            Console.WriteLine("Total Estate Points: " + estateAmount);
            Console.WriteLine("Total Duchy Points: " + duchyPoints);
            Console.WriteLine("Total Province Points: " + provincePoints);

            Console.WriteLine("\nTotal Points: " + totalPoints);
            Logicfile.GoAgainNotice();
        }
    }

    static void TheDefense()
    {
        while (true)
        {
            Console.Title = "Defense of Consolas";
            int row;
            int column;
            int mrLeft;
            int mrDown;
            int mrRight;
            int mrUp;

            Console.Clear();
            Console.WriteLine("8 X X X X X X X");
            Console.WriteLine("7 X X X X X X X");
            Console.WriteLine("6 X X X X X X X");
            Console.WriteLine("5 X X X X X X X");
            Console.WriteLine("4 X X X X X X X");
            Console.WriteLine("3 X X X X X X X");
            Console.WriteLine("2 X X X X X X X");
            Console.WriteLine("1 2 3 4 5 6 7 8\n");

            row = Logicfile.AskForNumber("Sir, what is the target row?");

            column = Logicfile.AskForNumber("And what about the target column?");

            Console.WriteLine("You heard the boss!\n");

            mrLeft = column - 1;
            mrDown = row - 1;
            mrRight = column + 1;
            mrUp = row + 1;
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("NOTE: (Left number is Row, right number is Column)\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Mr. Left Postion: {row}, {mrLeft}");
            Console.WriteLine($"Mr. Down Postion: {mrDown}, {column}");
            Console.WriteLine($"Mr. Right Position: {row}, {mrRight}");
            Console.WriteLine($"Mr. Up Postion: {mrUp}, {column}");
            Console.ResetColor();
            Console.Beep(37, 23);
            Console.Beep(137, 233);
            Console.Beep(337, 433);
            Console.Beep(637, 733);
            Console.Beep(737, 833);
            Logicfile.GoAgainNotice();
        }
    }

    static void TickTock()
    {
        while (true)
        {
            int number = 0;

            Console.Clear();

            number = Logicfile.AskForNumber("Enter a number...");

            if (number % 2 == 0)
            {
                Console.WriteLine("Tick");
            }
            else if (number % 2 == 1)
            {
                Console.WriteLine("Tock");
            }
            Logicfile.GoAgainNotice();
        }
    }

    static void Watchtower()
    {
        while (true)
        {
            int xValue;
            int yValue;
            Console.Clear();

            Console.WriteLine("    x<0 | x=0 | x>0");
            Console.WriteLine("y>0  NW    N    NE");
            Console.WriteLine("y=0  W     !    E");
            Console.WriteLine("y<0  SW    S    SE\n");

            xValue = Logicfile.AskForNumber("Enter the X value.");

            yValue = Logicfile.AskForNumber("Now enter the Y value.");

            if (xValue < 0 && yValue > 0)
            {
                Console.WriteLine("The enemy is to the North West!");
            }
            else if (xValue < 0 && yValue == 0)
            {
                Console.WriteLine("The enemy is to the West!");
            }
            else if (xValue < 0 && yValue < 0)
            {
                Console.WriteLine("The enemy is to the South West!");
            }
            else if (xValue == 0 && yValue > 0)
            {
                Console.WriteLine("The enemy is to the North!");
            }
            else if (xValue == 0 && yValue == 0)
            {
                Console.WriteLine("The enemy is in our Watchtower!");
            }
            else if (xValue == 0 && yValue < 0)
            {
                Console.WriteLine("The enemy is to the South!");
            }
            else if (xValue > 0 && yValue > 0)
            {
                Console.WriteLine("The enemy is to the North East!");
            }
            else if (xValue > 0 && yValue == 0)
            {
                Console.WriteLine("The enemy is to the East!");
            }
            else if (xValue > 0 && yValue < 0)
            {
                Console.WriteLine("The enemy is to the South East!");
            }
            Logicfile.GoAgainNotice();
        }
    }

    static void TheShop()
    {
        while (true)
        {
            long itemPrice = 0;
            bool knowsName = true;
            bool drunk = false;
            string response;
            string choice;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Ambrose Crowley: Hey, you look sorta familar... what's your name?\n");
            Console.ResetColor();

            string name = Console.ReadLine().ToLower();
            if (name == "tony")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Ambrose Crowley: I knew it was you Haha.. enjoy your 50% discount!");
            }
            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Ambrose Crowley: Ah, ok.. nevermind. thought you someone else.");
                knowsName = false;
            }

            Console.ResetColor();
            Console.WriteLine("\nPress enter to continue...");
            Console.ReadLine();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Ambrose Crowley: So what can I get for you {name}?\n");
            Console.ResetColor();

            Console.WriteLine("1) Liquid flask of Immortality");
            Console.WriteLine("2) Book of all things demons");
            Console.WriteLine("3) The Holy Grail");
            Console.WriteLine("4) Dating Software-Engineers for dummies");
            Console.WriteLine("5) Half-Life 3 (PC)");
            Console.WriteLine("6) A Large purple Dildo");
            Console.WriteLine("7) A Fanny-pack");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    itemPrice += 1000000000000;
                    break;
                case "2":
                    itemPrice += 180;
                    break;
                case "3":
                    itemPrice += 350000000000;
                    break;
                case "4":
                    itemPrice += 34;
                    break;
                case "5":
                    itemPrice += 80;
                    break;
                case "6":
                    itemPrice += 40;
                    break;
                case "7":
                    itemPrice += 13;
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Ambrose Crowley: You must be drunk... get out of my store!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    drunk = true;
                    break;
            }

            if (drunk == true)
            {
                Logicfile.GoAgainNotice();
            }
            else if (drunk == false)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                if (knowsName) { itemPrice /= 2; }

                Console.WriteLine($"Ambrose Crowley: So that will cost you ${itemPrice} freedom dollars.");
                Console.ResetColor();
                Logicfile.GoAgainNotice();
            }
        }
    }

    static void Loops()
    {
        while (true)
        {
            int userNumber;
            int userGuess = 1;
            bool userCorrectGuess;

            Console.Clear();
            do
            {
                Console.Clear();
                userNumber = Logicfile.AskForNumber("Hey Pilot, enter a numbet between 1 and 100.");
                Console.Clear();
            }
            while (userNumber <= 0 || userNumber >= 101);

            do
            {
                userGuess = Logicfile.AskForNumber("Alright Hunter, Guess the number.");

                if (userGuess > userNumber)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Too high!\n");
                    Console.ResetColor();
                }
                else if (userGuess < userNumber)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Too low!\n");
                    Console.ResetColor();
                }
            } while (userGuess != userNumber);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("HOLLYY SHIIIIT! YOU GOT IT!");
            Logicfile.GoAgainNotice();
        }
    }

    static void MagicCannon()
    {
        while (true)
        {
            int userNumber;
            int x = 0;
            Console.Clear();

            userNumber = Logicfile.AskForNumber("How high of a number do you want to check the Magic Cannon for?");

            Console.Clear();
            for (x = 1; x <= userNumber; x++)
            {
                if (x % 3 == 0 && x % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"{x}.Fire and Electric");
                    Console.WriteLine("--------------------");
                    Console.ResetColor();
                }
                else if (x % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{x}.Fire");
                    Console.WriteLine("--------------------");
                    Console.ResetColor();
                }
                else if (x % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{x}.Electric");
                    Console.WriteLine("--------------------");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"{x}.Normal");
                    Console.WriteLine("--------------------");
                    Console.ResetColor();
                }
            }
            Logicfile.GoAgainNotice();
        }
    }

    static void AnArray()
    {
        int[] array = new int[5];
        int[] copiedArray = new int[5];
        int numberCountdown = 5;
        int userNumber;
        int arraySelector = 0;

        while (numberCountdown > 0)
        {
            Console.Clear();

            userNumber = Logicfile.AskForNumber($"Enter a number. {numberCountdown} to go.");
            array[arraySelector] = userNumber;
            numberCountdown--;
            arraySelector++;
        }
        Console.Clear();

        copiedArray = array;
        for (int i = 0; i < copiedArray.Length; i++)
        {
            Console.WriteLine("MAIN ARRAY");
            Console.WriteLine(array[i]);
            Console.WriteLine("COPIED ARRAY");
            Console.WriteLine(copiedArray[i]);
            Console.ReadLine();
        }
        Logicfile.EndMethodNotice();
    }

    static void ForEach()
    {
        float average = 23.2f;
        int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };         //after
        int total = 0;
        foreach (int index in array)
        {
            total += index;
        }
        average = (float)total / array.Length;
        Console.WriteLine(average);
        Logicfile.EndMethodNotice();
        //-------------------------------------------------------------------------------------------
        int[] arrayy = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };          //before
        int totall = 0;
        for (int index = 0; index < array.Length; index++)
            total += array[index];
        float averagee = (float)total / array.Length;
        Console.WriteLine(average);
    }

    static void NumberTest()
    {
        Console.Clear();
        int result = Logicfile.AskForNumber("How many genders are there?");

        if (result == 2)
        {
            Console.WriteLine("Correct!");
            Logicfile.EndMethodNotice();
        }
        else
        {
            Console.WriteLine("You're pretty stupid, aren't you?");
            Logicfile.EndMethodNotice();
        }
    }

    public static int recursiveInt = 11;

    static void Recursive()
    {
        recursiveInt--;

        if (recursiveInt >= 1)
        {
            Console.WriteLine("------");
            Console.WriteLine($"{recursiveInt}");
        }
        else Logicfile.EndMethodNotice();
        Recursive();
    }

    // ---------------------------------------- START OF MANTICORE BOSS ----------------------------------------

    static int manticoreLocation;
    static int round = 1;
    static int cityHP = 15;
    static int cityMaxHP = 15;
    static int manticoreHP = 10;
    static int manticoreMaxHP = 10;
    static int manticoreDamage = 1;
    static int userRange;
    static int cannonDamage = 1;
    static string textUserRange = "- oh, You haven't fired yet.";

    static void TheManticore()
    {
        while (true)
        {
            Console.Clear();
            manticoreLocation = Logicfile.AskForNumber("Player 1, how far away do you want to station the Manticore?");
            Console.Clear();
            ManticoreBattleScreen();

            static void ManticoreBattleScreen()
            {
                while (manticoreHP > 0 && cityHP > 0)
                {
                    Console.WriteLine($"Round:{round} | CityHP: {cityHP}/{cityMaxHP} | ManticoreHP: {manticoreHP}/{manticoreMaxHP}");
                    Console.WriteLine($"The cannon will deal {cannonDamage} damage this round.");
                    userRange = Logicfile.AskForNumber("\nEnter Cannon range.");
                    CannonRangeInfo();

                    ManticoreCalculation();
                }
                ManticoreEndScreen();
            }

            static void CannonRangeInfo()
            {
                if (userRange > manticoreLocation)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    textUserRange = "too high";
                }
                else if (userRange < manticoreLocation)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    textUserRange = "too low";
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    textUserRange = "a hit!";
                    manticoreHP -= cannonDamage;
                }
                Console.WriteLine($"That shot was {textUserRange}!");
                Console.ResetColor();
            }


            static void ManticoreEndScreen()
            {
                if (manticoreHP <= 0 && cityHP <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("==========================");
                    Console.WriteLine("\nOh.. well that wasn't supposed to happen. I guess we both lose.");
                }
                else if (manticoreHP <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("==========================");
                    Console.WriteLine("\nWe defeated the Manticore!!!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("==========================");
                    Console.WriteLine("\nWE LOST! GOD, YOUR A STUPID IDIOT! YOU DOOMED US ALL!!!!");
                }


                 manticoreLocation = 0;
                 round = 1;
                 cityHP = 15;
                 cityMaxHP = 15;
                 manticoreHP = 10;
                 manticoreMaxHP = 10;
                 manticoreDamage = 1;
                 userRange = 0;
                 cannonDamage = 1;
                 textUserRange = "- oh, You haven't fired yet.";

                Logicfile.GoAgainNotice();
            }

            static void ManticoreCalculation()
            {
                round++;
                cityHP -= manticoreDamage;

                if (round % 3 == 0 && round % 5 == 0)
                {
                    cannonDamage = 10;
                }
                else if (round % 3 == 0 || round % 5 == 0)
                {
                    cannonDamage = 3;
                }
                else
                {
                    cannonDamage = 1;
                }
            }
        }
        // ---------------------------------------- END OF MANTICORE BOSS ----------------------------------------
    }

    static void EnumStates()
    {
        Logicfile.Treasure TreasureState = Logicfile.Treasure.open;
        string treasureState = "open";
        string input;
        string errorMessage = "";
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("NOTE: you can type in open, close, lock, unlock - depending on current state of the chest)\n");
        Console.ResetColor();
        while (true)
        {
            Console.WriteLine($"The chest is {treasureState}. What do you wanna do?");

            input = Console.ReadLine().ToLower();

            if (input == "close" && TreasureState == Logicfile.Treasure.open)
            {
                treasureState = "closed";
                TreasureState = Logicfile.Treasure.closed;
            }
            else if (input == "lock" && TreasureState == Logicfile.Treasure.closed)
            {
                treasureState = "locked";
                TreasureState = Logicfile.Treasure.locked;
            }
            else if (input == "unlock" && TreasureState == Logicfile.Treasure.locked)
            {
                treasureState = "closed";
                TreasureState = Logicfile.Treasure.closed;
            }
            else if (input == "open" && TreasureState == Logicfile.Treasure.closed)
            {
                treasureState = "opened";
                TreasureState = Logicfile.Treasure.open;
            }
            else
            {
                Logicfile.InvalidInput();
            }
        }
    }

    static void TupleSoup()
    {
        (Logicfile.EnumType Type, Logicfile.EnumIngredient Ingredient, Logicfile.EnumSeasoning Seasoning) soup;
        Console.Clear();
        while (true)
        {
            soup.Type = (Logicfile.EnumType)Logicfile.AskForNumber("Select a soup type.\n1) Soup\n2) Stew\n3) Gumbo");
            Console.Clear();
            soup.Ingredient = (Logicfile.EnumIngredient)Logicfile.AskForNumber("Select an ingredient.\n1) Mushroom\n2) Chicken\n3) Carros\n4) Potatos");
            Console.Clear();
            soup.Seasoning = (Logicfile.EnumSeasoning)Logicfile.AskForNumber("Select a seasoning.\n1) Spicy\n2) Salty\n3) Sweet");
            Console.Clear();
            Console.WriteLine($"Cool, you made yourself a {soup.Seasoning} {soup.Ingredient} {soup.Type}");
            Logicfile.GoAgainNotice();
        }
    }
    public static void Arrows()
    {
        Console.Clear();
        while (true)
        {
            float length = 0;
            int headCost = 0;
            int fletcherCost = 0;
            float lengthCost = 0;
            int gold = 0;
            float cost = 0;
            int input = 0;

            Arrow.FletchingType selectedFletching = Arrow.FletchingType.plastic;
            Arrow.Arrowhead selectedArrowhead = Arrow.Arrowhead.steel;
            input = Logicfile.AskForNumber("What type of Arrowhead do you want?\n1) Steel | 10 Gold\n2) Wood | 3 Gold\n3) Obsidian | 5 Gold\n4) Pre-made Arrow");

            switch (input)
            {
                case 1:
                    selectedArrowhead = Arrow.Arrowhead.steel;
                    gold += 10;
                    headCost = 10;
                    break;
                case 2:
                    selectedArrowhead = Arrow.Arrowhead.wood;
                    gold += 3;
                    headCost = 3;
                    break;
                case 3:
                    selectedArrowhead = Arrow.Arrowhead.obsidian;
                    gold += 5;
                    headCost = 5;
                    break;
                case 4:
                    int arrowChose = Logicfile.AskForNumber("What kind of pre-made arrow do you want?\n1) Elite Arrow: Steel Arrowhead, Plastic Fletching, 95cm long\n2) The Beginner Arrow: Wood Arrowhead, Goose Feather, 75cm long\n3) The Marksmen Arrow: Steel Arrowhead, Goose Feathers, 65cm long");
                    if (arrowChose == 1)
                    {
                        Arrow spawnedArrow = Arrow.CreateEliteArrow ();
                        headCost = 10;
                        fletcherCost = 10;
                        length = 95;
                        cost = Arrow.GetCost(95);              
                    }
                    else if (arrowChose == 2)
                    {
                        Arrow spawnedArrow = Arrow.CreateEliteArrow();
                        headCost = 3;
                        fletcherCost = 3;
                        length = 75;
                        cost = Arrow.GetCost(75);
                    }
                    else
                    {
                        Arrow spawnedArrow = Arrow.CreateEliteArrow();
                        headCost = 10;
                        fletcherCost = 3;
                        length = 65;
                        cost = Arrow.GetCost(65);
                    }
                    lengthCost = cost;
                    cost += headCost + fletcherCost;
                    Console.WriteLine($"Arrowhead: {selectedArrowhead} = {headCost} Gold\nFletching: {selectedFletching} = {fletcherCost} Gold\nArrow Length: {length} = {lengthCost} Gold\nTotal Cost: {cost}");
                    Logicfile.GoAgainNotice();
                    Arrows();
                    break;
            }
            Console.Clear();

            input = Logicfile.AskForNumber("What type of fletching do you want?\n1) Plastic | 10 Gold\n2) Turkey Feathers | 5 Gold\n3) Goose Feathers | 3 Gold");

            switch (input)
            {
                case 1:
                    selectedFletching = Arrow.FletchingType.plastic;
                    gold += 10;
                    fletcherCost = 10;
                    break;
                case 2:
                    selectedFletching = Arrow.FletchingType.turkey_feathers;
                    gold += 5;
                    fletcherCost = 5;
                    break;
                case 3:
                    selectedFletching = Arrow.FletchingType.goose_feathers;
                    gold += 3;
                    fletcherCost = 3;
                    break;
            }
            Console.Clear();
            length = Convert.ToSingle(Logicfile.AskForNumber("How long do you want your arrow to be? (Must be between 60 and 100 CM and costs 0.20 Gold per CM)"));

            if (length < 60 || length > 100)
            {
                Logicfile.InvalidInput();
            }
            else
            {
                cost = Arrow.GetCost(length);
                lengthCost = cost;
                cost += gold;
                Arrow spawnedArrow = new Arrow();

                Console.WriteLine($"Arrowhead: {selectedArrowhead} = {headCost} Gold\nFletching: {selectedFletching} = {fletcherCost} Gold\nArrow Length: {length} = {lengthCost} Gold\nTotal Cost: {cost}");
                Logicfile.GoAgainNotice();
            }
        }
    }
}