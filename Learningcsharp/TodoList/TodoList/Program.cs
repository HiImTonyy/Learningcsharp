class Numbers
{
    public static int numberTest;
}

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Hey dude, what do you wanna do?\n");

        Console.WriteLine("1) See all lists");
        Console.WriteLine("2) Add item to list");
        Console.WriteLine("3) Remove item from list");
        Console.WriteLine("4) Exit");
        Console.WriteLine("5) Bullshit testing stuff");
        var userChoice = Console.ReadLine();

        if (userChoice == "5")
        {
            TestingShit();
        }

        Console.ReadKey();
    }

    static void TestingShit()
    {
        Console.Clear();
        Console.WriteLine("What do you wanna test my dude?\n");

        Console.WriteLine("1) If/else Statements");
        Console.WriteLine("9) Misc");

        var userChoice = Console.ReadLine();

        if (userChoice == "1")
        {
            IfElseTest();
        }
        if (userChoice == "9")
            Misc();
    }

    static void IfElseTest()
    {
        Console.Clear();
        Console.WriteLine($"Value: {Numbers.numberTest}");
        Console.WriteLine("1) Increase value by 1");
        Console.WriteLine("2) Decrease value by 1");
        Console.WriteLine("69) Go back");
        Console.WriteLine("99) Main Menu");
        var userChoice = Console.ReadLine();

        if (userChoice == "1")
        {
            Numbers.numberTest++;
            IfElseTest();
        }
        else if (userChoice == "2")
        {
            Numbers.numberTest--;
            IfElseTest();
        }
        else if (userChoice == "69")
        {
            TestingShit();
        }
        else if (userChoice == "99")
        {
            Main();
        }
        else if (userChoice == " ");
        {
            IfElseTest();
        }
    }

    static void Misc()
    {
        Console.Clear();
        Console.WriteLine("You are there my dude, just press whatever to load variables.");
        var userChoice = Console.ReadLine();

        bool isUserInputAbc = userChoice == "1"; // Checks to see if true
        bool isUserInputNotAbc = userChoice != "ABC"; // Checks to see if false
        bool isUserInputNotAbc2 = !(userChoice == "ABC"); // Another way of seeing if false

        var number = 10;

        var isLargerThan5 = number > 5;
        var isSmallerThan10 = number < 10;
        var isLargerorEqualTo10 = number >= 10;
        var isSmallerOrEqualTo6 = number <= 6;
        var result = 10 % 5;
        var isLargerThan4AndSmallerThan9 = number > 4 && number < 9;
        var isEqualTo2OrLargerThan6OrSmallerThan200 = number == 2 || number > 6 || number < 200;
        var isEqualTo123OrEvenAndSmallerThan20 = number == 123 || (number % 2 == 0 && number < 20);
    }
}