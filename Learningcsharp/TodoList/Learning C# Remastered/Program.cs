﻿using System;
using System.Data.Common;
using System.Numerics;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

class Program
{
    public static void Main()
    {
        Console.Title = "Learning C# Remastered: Electric Boogaloo 2000 and one part LXIX";
        Console.Clear();
        Console.WriteLine("Choose a Method...\n");

        Console.WriteLine("1) The Makings of A Programmer");
        Console.WriteLine("2) Consolas and Telim");
        Console.WriteLine("3) The Thing Namer 3000");
        Console.WriteLine("4) The Variable Shop + The Variable Shop Returns");
        Console.WriteLine("5) The Triangle Farmer");
        Console.WriteLine("6) The Four Sisters and the Duckbear");
        Console.WriteLine("7) The Dominion of Kings");
        Console.WriteLine("8) The Defense of Consolas");
        Console.WriteLine("9) Repairing the CLocktower");
        Console.WriteLine("10) Watchtower");
        Console.WriteLine("11) Buying Inventory and Discounted Inventory");
        Console.WriteLine("12) The Prototype");
        Console.WriteLine("13) The Magic Cannon");
        Console.WriteLine("14) The Replicator of D'To");
        Console.WriteLine("15) The Laws of French");
        Console.WriteLine("16) Taking numbers");
        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Makings();
                break;
            case "2":
                Consolas();
                break;
            case "3":
                Thing3000();
                break;
            case "4":
                VariableShop();
                break;
            case "5":
                TriangleFarmer();
                break;
            case "6":
                FourSisters();
                break;
            case "7":
                Kings();
                break;
            case "8":
                ConsolasDefense();
                break;
            case "9":
                ClockTower();
                break;
            case "10":
                WatchTower();
                break;
            case "11":
                BuyingInventory();
                break;
            case "12":
                Prototype();
                break;
            case "13":
                Cannon();
                break;
            case "14":
                Replicator();
                break;
            case "15":
                French();
                break;
            case "16":
                GetNumber();
                break;
            case "test":
                Test();
                break;

            default:
                Main();
                break;
        }
    }

    public static void Makings()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Objective: Make a program with 5 Console.WriteLine statements in it\n");
        Console.ResetColor();

        Console.WriteLine("This is certainly something.");
        Console.WriteLine("Some dude asked to do programming stuff.");
        Console.WriteLine("So I did.");
        Console.WriteLine("The whole world fell apart.");
        Console.WriteLine("I regret nothing.");

        Console.WriteLine("\nEnd of method...");
        Console.ReadLine();
        Main();
    }

    public static void Consolas()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Bread is ready.");
        Console.WriteLine("Who is the bread for?");
        Console.WriteLine("RB");
        Console.WriteLine("Noted: RB got bread.\n");

        Console.WriteLine("Objective: Make a program that runs as shown above, including taking a name from the user\n");
        Console.ResetColor();

        Console.WriteLine("Bread is ready.");
        Console.WriteLine("Who is this bread for?");
        string name = Console.ReadLine();
        Console.WriteLine("Noted: " + name + " got bread.");

        Console.WriteLine("\nEnd of method... go again? y/n");
        string userInput = Console.ReadLine();
        userInput = userInput.ToLower();
        if (userInput == "y")
        {
            Consolas();
        }
        else
        {
            Main();
        }
    }

    public static void Thing3000()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Objective: Add comments near each of the four variables that describe what they store.\nYou must use at least one of each comment type (// and /* */). Find the bug in the text displayed and fix it\n");
        Console.ResetColor();

        Console.WriteLine("What kind of thing are we talking about?");
        string a = Console.ReadLine(); // Askes user to type whatever and stores it as string (a thing)                                                                
        Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
        string b = Console.ReadLine(); // Adds a description and stores it as a string. (big, zure, etc)
        string c = " of Doom"; // Another string, added because... why not?
        string d = "3000"; // Super random omega something. another string added because "LmaoXDSoRandom!"
        Console.WriteLine("The " + b + " " + a + c + " " + d + "!");

        Console.WriteLine("\nEnd of method... go again? y/n");
        string userInput = Console.ReadLine();
        userInput = userInput.ToLower();
        if (userInput == "y")
        {
            Thing3000();
        }
        else
        {
            Main();
        }

        /* =======================================================================================================       
        THE ORIGINAL CODE:

         Console.WriteLine("What kind of thing are we talking about?");
        string a = Console.ReadLine();
        Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
        string b = Console.ReadLine();
        string c = "of Doom";
        string d = "3000";
        Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");
        =======================================================================================================
         */
    }

    public static void VariableShop()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Objective: Build a program with a variable of all fourteen types described in this level.\nAssign each of them a value using a literal of the correct type.\nUse Console.WriteLine to display the contents of each variable.\nTypes are: int, short, long, byte, sbyte, uint, ushort, ulong, char, string, float, double, decimal, and bool.\n");
        Console.ResetColor();

        int number = 1000;
        short shortNumber = 32000;
        long longNumber = 9000000000000000;
        byte byteNmber = 255;
        sbyte smallByte = 127;
        uint uNumber = 0;
        ushort ushortNumber = 0;
        ulong ulongNumber = 0;
        char car = 'c';
        string strung = "15BucksLittleManPutThatShitInMyHand";
        float f = 3.40293f;
        double d = 1.232;
        decimal decimalNumber = 1010103221.232323m;
        bool boolean = true;

        Console.WriteLine("int: " + number);
        Console.WriteLine("short: " + shortNumber);
        Console.WriteLine("long: " + longNumber);
        Console.WriteLine("byte: " + byteNmber);
        Console.WriteLine("sbyte: " + smallByte);
        Console.WriteLine("uint: " + uNumber);
        Console.WriteLine("ushort: " + ushortNumber);
        Console.WriteLine("ulong: " + ulongNumber);
        Console.WriteLine("char: " + 'c');
        Console.WriteLine("string: " + strung);
        Console.WriteLine("float: " + f);
        Console.WriteLine("double: " + d);
        Console.WriteLine("decimal: " + decimalNumber);
        Console.WriteLine("bool: " + boolean);

        Console.WriteLine("\nEnd of method...");
        Console.ReadLine();
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Objective: Modify your Variable Shop program to assign a new,\ndifferent literal value to each of the 14 original variables.\nDo not declare any additional variables. Use Console.WriteLine to display the updated contents of each variable.");
        Console.ResetColor();

        number = 3000;
        shortNumber = 1000;
        longNumber = 9343413213123;
        byteNmber = 124;
        smallByte = 27;
        uNumber = 10;
        ushortNumber = 56;
        ulongNumber = 123892730;
        car = 'a';
        strung = "IfThatMoneyDoesntShowThenYouOweMeOweMeOh";
        f = 0.00290f;
        d = 6.111;
        decimalNumber = 99999999.333333m;
        boolean = false;

        Console.WriteLine("int: " + number);
        Console.WriteLine("short: " + shortNumber);
        Console.WriteLine("long: " + longNumber);
        Console.WriteLine("byte: " + byteNmber);
        Console.WriteLine("sbyte: " + smallByte);
        Console.WriteLine("uint: " + uNumber);
        Console.WriteLine("ushort: " + ushortNumber);
        Console.WriteLine("ulong: " + ulongNumber);
        Console.WriteLine("char: " + 'c');
        Console.WriteLine("string: " + strung);
        Console.WriteLine("float: " + f);
        Console.WriteLine("double: " + d);
        Console.WriteLine("decimal: " + decimalNumber);
        Console.WriteLine("bool: " + boolean);
        Console.WriteLine("\nEnd of method...");
        Console.ReadLine();
        Console.Clear();
        Main();
    }

    public static void TriangleFarmer()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Area = base x height / 2");
        Console.WriteLine("Objective: Write a program that lets you input the triangle’s base size and height.\nCompute the area of a triangle by turning the above equation into code. Write the result of the computation.\n");
        Console.ResetColor();

        int triangleBase = TakingSouls("Enter a number for the base of the triangle.");
        int triangleHeight = TakingSouls("Now enter the height for the triangle.");

        float area = (triangleBase * triangleHeight) / 2f;
        Console.WriteLine("Answer: " + area);

        Console.WriteLine("\nEnd of method... go again? y/n");
        string userInput = Console.ReadLine();
        userInput = userInput.ToLower();
        if (userInput == "y")
        {
            TriangleFarmer();
        }
        else
        {
            Main();
        }
    }

    public static void FourSisters()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Objective: Create a program that lets the user enter the number of chocolate eggs gathered that day.\nUsing / and %, compute how many eggs each sister should get and how many are left over for the duckbear.\n");
        Console.ResetColor();

        int eggsCollected = TakingSouls("How many chocolate eggs did you collect today?");

        int eggsDivided = eggsCollected / 4;
        int eggsLeftover = eggsCollected % 4;

        Console.WriteLine("\nEggs collected: " + eggsCollected);
        Console.WriteLine("Each sister gets " + eggsDivided + " eggs.");
        Console.WriteLine("Eggs Leftover for Duckbear: " + eggsLeftover);

        Console.WriteLine("\nEnd of method... go again? y/n");
        string userInput = Console.ReadLine();
        userInput = userInput.ToLower();
        if (userInput == "y")
        {
            FourSisters();
        }
        else
        {
            Main();
        }
    }

    public static void Kings()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Objective: Create a program that allows users to enter how many provinces, duchies, and estates they have.\nAdd up the user’s total score, giving 1 point per estate, 3 per duchy, and 6 per province.\nDisplay the point total to the user.\n");
        Console.ResetColor();

        int provinces = TakingSouls("How many provinces do you have?");
        int duchies = TakingSouls("How many duchies do you have?");
        int estates = TakingSouls("How many estates do you have?");

        int provincesPoint = 6;
        int duchiesPoint = 3;
        int estatePoint = 1;

        int totalPoints = (estates * estatePoint) + (duchies * duchiesPoint) + (provincesPoint * provinces);

        Console.WriteLine("\nTotal Points: " + totalPoints);

        Console.WriteLine("\nEnd of method... go again? y/n");
        string userInput = Console.ReadLine();
        userInput = userInput.ToLower();
        if (userInput == "y")
        {
            Kings();
        }
        else
        {
            Main();
        }
    }

    public static void ConsolasDefense()
    {
        Console.Clear();
        Console.Title = "Defense of Consolas";
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("8 X X X X X X X\n7 X X X X X X X\n6 X X X X X X X\n5 X X X X X X X\n4 X X X X X X X\n3 X X X X X X X\n2 X X X X X X X\n1 2 3 4 5 6 7 8\n");
        Console.WriteLine("Objective: Ask the user for the target row and column.\nCompute the neighboring rows and columns of where to deploy the squad.\nDisplay the deployment instructions in a different color of your choosing.\nChange the window title to be “Defense of Consolas”.\nPlay a sound with Console.Beep when the results have been computed and displayed.\n");
        Console.ResetColor();

        int row = TakingSouls("SIR, WHAT IS THE TARGET ROW?");
        int column = TakingSouls("GOT IT, NOW WHAT IS THE TARGET COLUMN?");

        int mrUpRow = row + 1;
        int mrUpColumn = column;

        int mrDownRow = row - 1;
        int mrDownColumn = column;

        int mrLeftRow = row;
        int mrLeftColumn = column - 1;

        int mrRightRow = row;
        int mrRightColumn = column + 1;

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"ALRIGHT BOYS, LETS SEND FREEDOM THEIR WAY..I MEAN, LETS DEFEND OUR FREEDOM!!!\n");

        Console.WriteLine("POSITIONS");
        Console.WriteLine("=========");
        Console.WriteLine("ROW|COLUMN");
        Console.WriteLine("----------");
        Console.WriteLine($"Mr. Up: {mrUpRow}, {mrUpColumn}");
        Console.WriteLine($"Mr. Down: {mrDownRow}, {mrDownColumn}");
        Console.WriteLine($"Mr. Left: {mrLeftRow}, {mrLeftColumn}");
        Console.WriteLine($"Mr. Right: {mrRightRow}, {mrRightColumn}\n");

        Thread.Sleep(5500);
        Console.WriteLine("THEY GAVE UP THEIR BOMBARDMENT AND ARE RETREATING, LIBRETY AND DEMOCROCY PREVAILS!!");

        Console.Beep(659, 500);
        Thread.Sleep(50);
        Console.Beep(784, 500);
        Thread.Sleep(50);
        Console.Beep(988, 500);
        Thread.Sleep(50);
        Console.Beep(880, 750);
        Thread.Sleep(50);
        Console.Beep(784, 1000);

        Console.ResetColor();
        Console.WriteLine("\nEnd of method... go again? y/n");
        string userInput = Console.ReadLine();
        userInput = userInput.ToLower();
        if (userInput == "y")
        {
            ConsolasDefense();
        }
        else
        {
            Main();
        }
    }

    public static void ClockTower()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Objective: Take a number as input from the console.\nDisplay the word “Tick” if the number is even. Display the word “Tock” if the number is odd.\n");
        Console.ResetColor();

        int number = TakingSouls("Enter a number...");
        number = number % 2;


        if (number == 1)
        {
            Console.WriteLine("TOCK");
        }
        else
        {
            Console.WriteLine("TICK");
        }

        Console.WriteLine("\nEnd of method... go again? y/n");
        string userInput = Console.ReadLine();
        userInput = userInput.ToLower();
        if (userInput == "y")
        {
            ClockTower();
        }
        else
        {
            Main();
        }
    }

    public static void WatchTower()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("     X<0  X=0  X>0\n");
        Console.WriteLine("y>0  NW   N    NE");
        Console.WriteLine("y=0  W    !    E");
        Console.WriteLine("y<0  SW   S    SE\n");

        Console.WriteLine("Objective: Ask the user for an x value and a y value.\nThese are coordinates of the enemy relative to the watchtower’s location.\nUsing the image on the top, if statements, and relational operators, display a message about what\ndirection the enemy is coming from.\nFor example, “The enemy is to the northwest!” or “The enemy is here!\n");
        Console.ResetColor();

        Console.WriteLine("Where are the enemies coming from?\n");

        int yAxis = TakingSouls("Enter Y axis:");
        int xAxis = TakingSouls("Enter X axis:");


        string message = "NULL";

        if (yAxis > 0 && xAxis < 0)
        {
            message = "North West";
        }
        else if (yAxis == 0 && xAxis < 0)
        {
            message = "West";
        }
        else if (yAxis < 0 && xAxis < 0)
        {
            message = "South West";
        }
        else if (yAxis > 0 && xAxis == 0)
        {
            message = "North";
        }
        else if (yAxis < 0 && xAxis == 0)
        {
            message = "South";
        }
        else if (yAxis > 0 && xAxis > 0)
        {
            message = "North East";
        }
        else if (yAxis == 0 && xAxis > 0)
        {
            message = "East";
        }
        else if (yAxis < 0 && xAxis > 0)
        {
            message = "South East";
        }
        else
        {
            Console.WriteLine("\nThey are in our city!");
            Console.WriteLine("\nEnd of method... go again? y/n");
            string userInputt = Console.ReadLine();
            userInputt = userInputt.ToLower();
            if (userInputt == "y")
            {
                WatchTower();
            }
            else
            {
                Main();
            }
        }

        Console.WriteLine($"\nThey are coming from the {message}!");

        Console.ResetColor();
        Console.WriteLine("\nEnd of method... go again? y/n");
        string userInput = Console.ReadLine();
        userInput = userInput.ToLower();
        if (userInput == "y")
        {
            WatchTower();
        }
        else
        {
            Main();
        }
    }


    // I know that the following is kinda a mess and that I was supposed to set the "gold" as a variable, but I just wanted to have fun with it. it still follows the objective so.. eh. 
    public static void BuyingInventory()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(
@"The following items are available:
1 – Rope
2 – Torches
3 – Climbing Equipment
4 – Clean Water
5 – Machete
6 – Canoe
7 – Food Supplies
What number do you want to see the price of? 2
Torches cost 15 gold.");

        Console.WriteLine("\nObjective: Build a program that will show the menu illustrated above.\nAsk the user to enter a number from the menu.\nUsing the information above, use a switch (either type) to show the item’s cost.\n" +
            "Objective two (after first is completed) Modify your program from before to also ask the user for their name.\nIf their name equals your name, divide the cost in half.\n");
        Console.ResetColor();

        bool know = false;

        Console.WriteLine("Hey.. I think I remember you. what is your name?\n");

        string answer = Console.ReadLine();

        if (answer == "William Watts")
        {
            Console.WriteLine("Oh, it is you! nice to see you man.");
            Console.ReadLine();
            know = true;
        }
        else if (answer == "ww")
        {
            Console.WriteLine("Oh yeahh, it is you! its nice to see you man.");
            Console.ReadLine();
            know = true;
        }
        else
        {
            Console.WriteLine("Oh, nah.. nevermind. I thought you were someone else.");
            Console.ReadLine();
        }

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(
@"The following items are available:
1 – Rope
2 – Torches
3 – Climbing Equipment
4 – Clean Water
5 – Machete
6 – Canoe
7 – Food Supplies
What number do you want to see the price of? 2
Torches cost 15 gold.");

        Console.WriteLine("\nObjective: Build a program that will show the menu illustrated above.\nAsk the user to enter a number from the menu.\nUsing the information above, use a switch (either type) to show the item’s cost.\n" +
            "Objective two (after first is completed) Modify your program from before to also ask the user for their name.\nIf their name equals your name, divide the cost in half.\n");
        Console.ResetColor();
        Console.WriteLine("The following items are avalible:\n");

        Console.WriteLine("1 - Rope");
        Console.WriteLine("2 - Torches");
        Console.WriteLine("3 - Climbing Equipment");
        Console.WriteLine("4 - Clean Water");
        Console.WriteLine("5 - Machete");
        Console.WriteLine("6 - Canoe");
        Console.WriteLine("7 - Food Supplies\n");

        Console.WriteLine("Alright dude, what do you wanna see the price of?\n");

        string dudesReply;
        string choice = Console.ReadLine();

        if (know != true)
        {
            dudesReply = choice switch
            {
                "1" => "A Rope? you plan on climbing or are you going to say GG and go next? ah well, it is what it is I guess.\nI ain't stopping you if you give me the ten Gold it costs.\nHell, I'll give you the two ropes for just fifteen gold incase the first one breaks.",
                "2" => "Ah, a Torch. It costs sixteen gold but.. to be honest, I have way too many in the back,\nso I'll give you five torches for just forty-eight gold instead of the eighty that it would cost.",
                "3" => "I have only two things of climbing equipment left.. a bunch of posh looking British men came in and took most of them.\nI can still hear their pocket-watches and smell their tobaccoo pipes.\n*the man shutters* I have a bad feeling about them but.. uh," +
                "yeah.. the climbing equipment will be just twenty-four gold.",
                "4" => "Just two gold for the clean water my dude and one extra if you want beer instead.",
                "5" => "You a hunter? in that case I'll give you the machete for free if you kill a few rats down in the basement. otherwise, it'll be twenty gold.",
                "6" => "Wow, a canoe? I haven't sold one in like.. ages. that'll be two-hundred gold.",
                "7" => "Food supplies? I think you had too much food supplies...... I'm kidding, that'll be two gold.",
                _ => "I might be wayy too high right now, because it sounded like you wanted something that we don't have."
            };
            Console.WriteLine($"\n{dudesReply}");
        }
        else
        {
            dudesReply = choice switch
            {
                "1" => "five gold man.. don't do anything stupid with it.",
                "2" => "eight gold only, just for you.",
                "3" => "Twelve gold. don't break your back now.",
                "4" => "One gold. no extra cost for the beer.",
                "5" => "ten Gold please.",
                "6" => "One-hundred thank you.",
                "7" => "Just one gold for you.",
                _ => "Dude... come on."
            };
            Console.WriteLine($"\n{dudesReply}");
        }

        Console.WriteLine("\nEnd of method... go again? y/n");
        string userInput = Console.ReadLine();
        userInput = userInput.ToLower();
        if (userInput == "y")
        {
            BuyingInventory();
        }
        else
        {
            Main();
        }
    }

    public static void Prototype()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Objective: Build a program that will allow a user, the pilot,to enter a number.\nIf the number is above 100 or less than 0, keep asking.\nClear the screen once the program has collected a good number.\nAsk a second user, the hunter,to guess numbers.\nIndicate whether the user guessed too high, too low, or guessed right.\nLoop until they get it right, then end the program.\n");
        Console.ResetColor();

        int pilotNumber;
        int hunterGuess;
        int guesses = 0;
        bool bozo = false;

        while (true)
        {
            pilotNumber = TakingSouls("\nEnter a number between - and 100.\n");

            if (pilotNumber > 100 || pilotNumber < 0)
            {
                Console.WriteLine("I said a number between 0 and 100 you bozo!");
                bozo = true;
                continue;
            }
            else
            {
                Console.Clear();
                break;
            }
        }
        while (true)
        {
            hunterGuess = TakingSouls("Guess the number Hunter.\n");

            if (hunterGuess == pilotNumber && bozo == true)
            {
                Console.WriteLine($"\nYou are correct! man, that Pilot was a real bozo.");
                break;
            }
            else if (hunterGuess == pilotNumber)
            {
                Console.WriteLine("\nWow, you actually guessed correctly. nice!");
                guesses++;
                break;
            }
            else if (hunterGuess > pilotNumber)
            {
                Console.WriteLine($"\n{hunterGuess} is too high, try again.");
                guesses++;
            }
            else if (hunterGuess < pilotNumber)
            {
                Console.WriteLine($"\n{hunterGuess} is too low, try again.");
                guesses++;
            }
        }

        Console.WriteLine($"Also, it took you {guesses} guesses to get the number correct.");
        Console.WriteLine("\nEnd of method... go again? y/n");
        string userInput = Console.ReadLine();
        userInput = userInput.ToLower();
        if (userInput == "y")
        {
            Prototype();
        }
        else
        {
            Main();
        }
    }

    public static void Cannon()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Objective: Write a program that will loop through the values between 1 and 100\n and display what kind of blast the crew should expect.\nChange the color of the output based on the type of blast.\n" +
            "Every third turn of a crank, the fire gem activates, and the cannon produces a fire blast.\nThe electric gem activates every fifth turn of the crank,\nand the cannon makes an electric blast.\nWhen the two line up, it generates a potent combined blast.\n");
        Console.ResetColor();
 
        int maxTurn = TakingSouls("Enter a number between 1 and 100 to check which blast it contains.\n");

        if (maxTurn < 1 || maxTurn > 100)
        {
            Console.WriteLine("IS THAT A NUMBER BETWEEN 1 AND 100? NO.. TRY AGAIN.");
            Console.ReadLine();
            Cannon();
        }

        for (int input = 1; input <= maxTurn; input++)
        {
            if (input % 3 == 0 && input % 5 == 0) 
            {
                Console.ForegroundColor = ConsoleColor.Blue; 
                Console.WriteLine($"{input}: Fire and Electric");
            }
            else if (input % 3 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine($"{input}: Fire");
            }
            else if (input % 5 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow; 
                Console.WriteLine($"{input}: Electric");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray; 
                Console.WriteLine($"{input}: God damn normie...");
            }
            Console.ResetColor(); 
        }

        Console.WriteLine("\nEnd of method... go again? y/n");
        string userInput = Console.ReadLine();
        userInput = userInput.ToLower();
        if (userInput == "y")
        {
            Cannon();
        }
        else
        {
            Main();
        }
    }

    public static void Replicator()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Objective: Make a program that creates an array of length 5. Ask the user for five numbers and put them in the array.\nMake a second array of length 5. Use a loop to copy the values out of the original array and into the new one.\nDisplay the contents of both arrays one at a time to illustrate that the Replicator of D’To works\n");
        Console.ResetColor();

        int[] array = new int[5];
        int[] copyCatArray = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Clear();
            Console.WriteLine($"Numbers entered: {i}\n");

            array[i] = TakingSouls("Enter five numbers.");
        }

        copyCatArray = array;
        Console.Clear();

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(array[i]);
        }
        Console.WriteLine("\nPress whatever see the copied version...");
        Console.ReadLine();
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(copyCatArray[i]);
        }

        Console.WriteLine("\nEnd of method... go again? y/n");
        string userInput = Console.ReadLine();
        userInput = userInput.ToLower();
        if (userInput == "y")
        {
            Replicator();
        }
        else
        {
            Main();
        }
    }

    public static void French()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Objective: Start with the code for computing an array’s minimum and average values.\nModify the code to use foreach loops instead of for loops.\n");
        Console.ResetColor();

        int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
        int total = 0;
        foreach (int number in array)
        {
            total += number;
        }
        float average = (float)total / array.Length;
        Console.WriteLine($"Average: {average}\n");

        Console.WriteLine(@"===============================================================
Code Before:
int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int total = 0;
for (int index = 0; index < array.Length; index++)
    total += array[index];

float average = (float)total / array.Length;
Console.WriteLine(average)
===============================================================

Code After:
 int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
 int total = 0;
 foreach (int number in array)
 {
     total += number;
 }
     float average = (float)total / array.Length;
     Console.WriteLine(average);");

        Console.WriteLine("\nEnd of method... go again? y/n");
        string userInput = Console.ReadLine();
        userInput = userInput.ToLower();
        if (userInput == "y")
        {
            French();
        }
        else
        {
            Main();
        }
    }

    /* Objective: Make a method with the signature int AskForNumber(string text). Display the text
    parameter in the console window, get a response from the user, convert it to an int, and return it.*/
    public static int TakingSouls(string text) 
    {
        Console.WriteLine(text);

        int number = Convert.ToInt32(Console.ReadLine());
        return number;
    }

    public static void GetNumber()
    {
        int result = TakingSouls("enter a number...");
        Console.WriteLine($"You put in: {result}.");
        Console.ReadLine();
        Main();
    }

    public static void Test()
    {
        Main();
    }
}