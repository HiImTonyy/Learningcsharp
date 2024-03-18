using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Choose a module...\n");

        Console.WriteLine("1) The Makings of A Programmer");
        Console.WriteLine("2) Consolas and Telim");
        Console.WriteLine("3) The Thing Namer 3000");
        Console.WriteLine("4) The Variable Shop + The Variable Shop Returns");
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
        }
    }

    public static void Makings()
    {
        Console.Clear();
        Console.WriteLine("Objective: Make a program with 5 Console.WriteLine statements in it\n");

        Console.WriteLine("This is certainly something.");
        Console.WriteLine("Some dude asked to do programming stuff.");
        Console.WriteLine("So I did.");
        Console.WriteLine("The whole world fell apart.");
        Console.WriteLine("I regret nothing.");

        Console.WriteLine("\nEnd of module...");
        Console.ReadLine();
        Main();
    }

    public static void Consolas()
    {
        Console.Clear();
        /* 
         Bread is ready.
         Who is the bread for?
         RB
         Noted: RB got bread.
        */

        Console.WriteLine("Objective: Make a program that runs as shown above, including taking a name from the user\n");

        Console.WriteLine("Bread is ready.");
        Console.WriteLine("Who is this bread for?");
        string name = Console.ReadLine();
        Console.WriteLine("Noted: " + name + " got bread.");

        Console.WriteLine("\nEnd of module...");
        Console.ReadLine();
        Main();
    }

    public static void Thing3000()
    {
        Console.Clear();
        Console.WriteLine("Objective: Add comments near each of the four variables that describe what they store.\nYou must use at least one of each comment type (// and /* */). Find the bug in the text displayed and fix it\n");

        Console.WriteLine("What kind of thing are we talking about?");
        string a = Console.ReadLine(); // Askes user to type whatever and stores it as string (a thing)                                                                
        Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
        string b = Console.ReadLine(); // Adds a description and stores it as a string. (big, zure, etc)
        string c = " of Doom"; // Another string, added because... why not?
        string d = "3000"; // Super random omega something. another string added because "LmaoXDSoRandom!"
        Console.WriteLine("The " + b + " " + a + c + " " + d + "!");

        Console.WriteLine("\nEnd of module...");
        Console.ReadLine();
        Main();

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
        Console.WriteLine("Objective: Build a program with a variable of all fourteen types described in this level.\nAssign each of them a value using a literal of the correct type.\nUse Console.WriteLine to display the contents of each variable.\nTypes are: int, short, long, byte, sbyte, uint, ushort, ulong, char, string, float, double, decimal, and bool.\n");

        int number = 1000;
        short shortNumber = 32000;
        long longNumber = 9000000000000000;
        byte byteNmber = 255;
        sbyte smallByte = 127;
        uint uNumber = 0;
        ushort ushortNumber = 0;
        ulong ulongNumber = 0;
        char car = 'c';
        string strung = "15BuckLittleManPutThatShitInMyHand";
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

        Console.WriteLine("\nEnd of module...");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Objective: Modify your Variable Shop program to assign a new,\ndifferent literal value to each of the 14 original variables.\nDo not declare any additional variables. Use Console.WriteLine to display the updated contents of each variable.");

        number = 3000;
        shortNumber = 1000;
        longNumber = 9343413213123;
        byteNmber = 124;
        smallByte = 27;
        uNumber = 10;
        ushortNumber = 56;
        ulongNumber = 123892730;
        car = 'a';
        strung = "IthinkIWantToKnowYeaYeahhWhaat";
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
        Console.WriteLine("\nEnd of module...");
        Console.ReadLine();
        Console.Clear();
        Main();
    }
}