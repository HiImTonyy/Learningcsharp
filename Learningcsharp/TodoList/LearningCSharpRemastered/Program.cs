class Program
{
    static bool methodInfoGoBack = false;
    public static void Main()
    {
        Console.Title = "LearningCSharpRemastered: Electric Boogaloo part LXIX";
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

            if (methodInfoGoBack)
                MethodInfo();
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
                case "info":
                    MethodInfo();
                    break;

                default:
                    InvalidInput();
                    break;
            }
        }
    }

    static void HelloWorld()
    {
        Console.Clear();
        Console.WriteLine("\"The road to hell is paved with good intentions and the ones you love litter the road-side.\"");
        EndMethodNotice();
    }

    static void MultipleLines()
    {
        Console.Clear();
        Console.WriteLine("This hardcore ghetto gangster image takes a lot of practice");
        Console.WriteLine("I'm not black like Barry White, no, I am white like Frank Black is");
        Console.WriteLine("So, if man is five and the devil is six, then that must make me seven");
        Console.WriteLine("This honkey's gone to heaven");
        Console.WriteLine("But if I go to hell, well, then I hope I burn well.");
        EndMethodNotice();
    }

    static void UserInput()
    {
        string person;
        Console.Clear();
        Console.WriteLine("Bread is ready.");
        Console.WriteLine("Who is the bread for?");
        person = Console.ReadLine();
        Console.WriteLine("Noted: " + person + " got bread.");
        EndMethodNotice();
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

        EndMethodNotice();
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
        EndMethodNotice();
    }

    static void Triangle()
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
        EndMethodNotice();
    }

    static void Remainder()
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
        EndMethodNotice();
    }

    static void ThreeKings()
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
        Console.WriteLine("Total Province Points: " +  provincePoints);

        Console.WriteLine("\nTotal Points: " +  totalPoints);
        EndMethodNotice();
    }

    static void TheDefense()
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
        EndMethodNotice();
    }

    static void TickTock()
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
        EndMethodNotice();
    }

    // ------ MISC STUFF ------ MISC STUFF ------ MISC STUFF ------ MISC STUFF ------- MISC STUFF ------ MISC STUFF ------
    // ------ MISC STUFF ------ MISC STUFF ------ MISC STUFF ------ MISC STUFF ------- MISC STUFF ------ MISC STUFF ------
    // ------ MISC STUFF ------ MISC STUFF ------ MISC STUFF ------ MISC STUFF ------- MISC STUFF ------ MISC STUFF ------

    static void MethodInfo()
    {
        while(true)
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
            };

            if (inputNumber >= infolist.Count)
            {
                Console.ForegroundColor= ConsoleColor.DarkRed;
                Console.WriteLine("We don't have that number. press enter if you understand.");
                Console.ReadLine();
                Console.ResetColor();
                methodInfoGoBack = true;
                Main();
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
                    Main();
                }
                else if (input == "2")
                {
                    Console.ResetColor();
                    methodInfoGoBack = false;
                    Main();
                }
                else
                {
                    InvalidInput();
                    methodInfoGoBack = true;
                    Main();
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
    }

    public static void EndMethodNotice()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n*************************************************************");
        Console.WriteLine("*** End of task. please press enter to exit current task. ***");
        Console.WriteLine("*************************************************************");
        Console.ReadLine();
        Console.ResetColor();
    }
}