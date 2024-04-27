using LearningCSharpRemastered;
using System.ComponentModel.Design;

class Program
{
    public static void Main()
    {
        Console.Title = "LearningCSharpRemastered: Electric Boogaloo part LXIX";
        Logicfile instance = new Logicfile();
        while (true)
        {

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
            if (Logicfile.methodInfoGoBack)
                Logicfile.MethodInfo();
            string input = Console.ReadLine().ToLower();
            switch (input)
            {
                case "test":
                    Logicfile.GoAgainNotice();
                    break;
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
        Console.WriteLine(code+"\n");

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

            Console.WriteLine("Type in the base of your triangle.\n");

            string triangleBaseText = Console.ReadLine();
            triangleBase = Convert.ToInt32(triangleBaseText);

            Console.Clear();
            Console.WriteLine("Now type in the height of your triangle.\n");

            string triangleHeightText = Console.ReadLine();
            triangleHeight = Convert.ToInt32(triangleHeightText);

            Console.Clear();
            triangleArea = (triangleBase * triangleHeight) / 2f;
            Console.WriteLine(triangleBase + " * " + triangleHeight + " / 2 = " + triangleArea);
            Console.WriteLine("So the area of the traingle is " + triangleArea);
            Logicfile.GoAgainNotice();
        }
    }

    static void Remainder()
    {
        while(true)
        {
            int eggsCollected;
            int eggsRemainder;
            int sistersEggCount;

            Console.Clear();
            Console.WriteLine("How many eggs did you collect today?\n");

            string eggsCollectedText = Console.ReadLine();
            eggsCollected = Convert.ToInt32(eggsCollectedText);

            sistersEggCount = eggsCollected / 3;
            eggsRemainder = eggsCollected % 3;


            Console.WriteLine("You collected " + eggsCollected);
            Console.WriteLine("Each of the 3 sister will recieve " + sistersEggCount);
            Console.WriteLine("The remainder is " + eggsRemainder + ". So their pet will just recieve " + eggsRemainder);
            Logicfile.GoAgainNotice();
        }
    }

    static void ThreeKings()
    {
        while(true)
        {
            int estateAmount;
            int duchyAmount;
            int provinceAmount;
            int duchyPoints = 0;
            int provincePoints = 0;
            int totalPoints = 0;

            Console.Clear();
            Console.WriteLine("How many Estates do you have?\n");

            string estateAmountText = Console.ReadLine();
            estateAmount = Convert.ToInt32(estateAmountText);

            Console.WriteLine("How many Duchies do you have?");

            string duchyAmountText = Console.ReadLine();
            duchyAmount = Convert.ToInt32(duchyAmountText);
            duchyPoints = duchyAmount * 3;

            Console.WriteLine("How many Provinces do you have?\n");

            string provinceAmountText = Console.ReadLine();
            provinceAmount = Convert.ToInt32(provinceAmountText);
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
        while(true)
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

            Console.WriteLine("Sir, what is the target row?");
            string rowText = Console.ReadLine();
            row = Convert.ToInt32(rowText);

            Console.WriteLine("And what about the target column?");
            string columnText = Console.ReadLine();
            column = Convert.ToInt32(columnText);

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
        while(true)
        {
            int number = 0;

            Console.Clear();
            Console.WriteLine("Enter a number.\n");

            string numberText = Console.ReadLine();
            number = Convert.ToInt32(numberText);

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
        while(true)
        {
            int xValue;
            int yValue;
            Console.Clear();

            Console.WriteLine("    x<0 | x=0 | x>0");
            Console.WriteLine("y>0  NW    N    NE");
            Console.WriteLine("y=0  W     !    E");
            Console.WriteLine("y<0  SW    S    SE\n");

            Console.WriteLine("Enter the X value.");
            string xValueText = Console.ReadLine();
            xValue = Convert.ToInt32(xValueText);

            Console.WriteLine("Now enter the Y value.");
            string yValueText = Console.ReadLine();
            yValue = Convert.ToInt32(yValueText);

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
        while(true)
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
                Console.Write("Hey Pilot, enter a number between 1 and 100\n");

                string userNumberText = Console.ReadLine();
                userNumber = Convert.ToInt32(userNumberText);
                Console.Clear();
            }
            while (userNumber <= 0 || userNumber >= 101);

            do
            {
                Console.WriteLine("Alright Hunter, Guess the number.\n");

                string userGuessText = Console.ReadLine();
                userGuess = Convert.ToInt32(userGuessText);

                if (userGuess > userNumber)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nToo high!");
                    Console.ResetColor();
                    Console.WriteLine("---------");
                }
                else if (userGuess < userNumber)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("\nToo low!");
                    Console.ResetColor();
                    Console.WriteLine("---------");
                }
            } while (userGuess != userNumber);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("HOLLYY SHIIIIT! YOU GOT IT!");
            Logicfile.GoAgainNotice();
        }
    }

    static void MagicCannon()
    {
        while(true)
        {
            int userNumber;
            int x = 0;
            Console.Clear();

            Console.WriteLine("How high of a number do you want to check the Magic Cannon for?\n");

            string userNumberText = Console.ReadLine();
            userNumber = Convert.ToInt32(userNumberText);

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
                    Console.ForegroundColor= ConsoleColor.Red;
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
            Console.WriteLine($"Enter a number. {numberCountdown} to go.\n");

            userNumber = Convert.ToInt32(Console.ReadLine());
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

    public static void NumberTest()
    {
        int result = AskForNumber("How many genders are there?");

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

    public static int AskForNumber(string text)
    {
        Console.Clear();
        Console.WriteLine($"{text}\n");

        int number = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        return number;
    }
}

