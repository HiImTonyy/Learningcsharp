using System.ComponentModel;
using System.Runtime.CompilerServices;
using TodoList;

class Numbers
{
    public static int numberTest;
}

class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.Write("Hey dude, what do you wanna do?\n");

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
        else
        {
            Main();
        }

        Console.ReadKey();
    }

    static void TestingShit()
    {
        Console.Clear();
        Console.WriteLine("What do you wanna test my dude?\n");

        Console.WriteLine("1) If/else Statements");
        Console.WriteLine("2) Selected Option Thing");
        Console.WriteLine("3) Call method from somewhere else");
        Console.WriteLine("4) Boolean check in word length");
        Console.WriteLine("5) Return whatever is typed");
        Console.WriteLine("6) Parsing");
        Console.WriteLine("7) Random Number");
        Console.WriteLine("8) Dice Game");
        Console.WriteLine("9) Certain words print out certain things");
        Console.WriteLine("10) Arrays");
        Console.WriteLine("11) Booleans");
        Console.WriteLine("12) Swtiches");
        Console.WriteLine("13) For Statement");
        Console.WriteLine("14) Do-While Start thing");
        Console.WriteLine("99) Misc");

        var userChoice = Console.ReadLine();

        if (userChoice == "1")
        {
            IfElseTest();
        }

        if (userChoice == "2")
        {
            SelectOption();
        }

        if (userChoice == "3")
        {
            var result = Add(10, 5);
            Console.Clear();
            Console.WriteLine("10 + 5 = " + result);
            Console.ReadLine();
            TestingShit();
        }

        if (userChoice == "4")
        {
            Console.Clear();
            var isLongChoice = Console.ReadLine();
            bool isLong = IsLong(isLongChoice);
            Console.WriteLine($"More than 5 words: {isLong}");
            Console.ReadLine();
            bool IsLong(string input)
            {
                return input.Length > 5;
            }
        }

        if (userChoice == "5")
        {
            Console.Clear();
            Console.WriteLine("Type whatever...\n");
            string name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(name);
            Console.ReadLine();
            TestingShit();
        }

        if (userChoice == "6")
        {
            Console.Clear();
            Console.WriteLine("What's your age?\n");
            string userAge = Console.ReadLine();
            Console.Clear();
            int parsedString = int.Parse(userAge);
            Console.WriteLine($"Age: {parsedString}");
            Console.ReadLine();
            TestingShit();                             // Already learned and implemented TryParse in the calculator, don't need to do it again here. 
        }

        if (userChoice == "7")
        {
            Random dice = new Random();
            int roll = dice.Next(1, 101);
            Console.WriteLine($"Random Number:\t{roll}");
            Console.ReadLine();
            TestingShit();
        }

        if (userChoice == "8")
        {
            DiceGame.DiceStart();
        }

        if (userChoice == "9")
        {
            Words.WordsStart();
        }

        if (userChoice == "10")
        {
            Arrays.ArrayStart();
        }

        if (userChoice == "11")
        {
            Bool.BooleanStart();
        }

        if (userChoice == "12")
        {
            SwitchStart();
        }

        if (userChoice == "13")
        {
            ForStart();
        }

        if (userChoice == "14")
        {
            DoWhileStart();
        }

        if (userChoice == "99")
        {
            Misc();
        }
        else
        {
            TestingShit();
        }

        // Choice 3.
        int Add(int a, int b)
        {
            return a + b;
        }
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
        else if (userChoice == " ")
        {
            IfElseTest();
        }
    }

    static void SelectOption()
    {
        Console.Clear();
        Console.WriteLine("Select Option Thing\n");
        Console.WriteLine("1) See thing");
        Console.WriteLine("2) Add thing");
        Console.WriteLine("3) Remove thing");

        var userChoice = Console.ReadLine();

        if (userChoice == "1")
        {
            PrintSelectedThing("See Thing");
        }
        if (userChoice == "2")
        {
            PrintSelectedThing("Add Thing");
        }
        if (userChoice == "3")
        {
            PrintSelectedThing("Remove Thing");
        }

        Console.ReadKey();

        void PrintSelectedThing(string selectedThing)
        {
            Console.Clear();
            Console.WriteLine("Selected option: " + selectedThing);
            Console.ReadKey();
            SelectOption();
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
        int test1 = 6 + 2 * 2; // 6 + 2 X 2
        int test2 = (6 + 2) * 2; // 7 * 3 anything in (X + X) goes first!

        var number = 10;

        var isLargerThan5 = number > 5;
        var isSmallerThan10 = number < 10;
        var isLargerorEqualTo10 = number >= 10;
        var isSmallerOrEqualTo6 = number <= 6;
        var result = 10 % 5;
        var isLargerThan4AndSmallerThan9 = number > 4 && number < 9;
        var isEqualTo2OrLargerThan6OrSmallerThan200 = number == 2 || number > 6 || number < 200;
        var isEqualTo123OrEvenAndSmallerThan20 = number == 123 || (number % 2 == 0 && number < 20);
        Console.Clear();
        Console.WriteLine($"Var is larger than 5: {isLargerThan5}\n" +
            $"Var is smaller than 10: {isSmallerThan10}");
        Console.ReadLine();
    }

    static void SwitchStart()
    {
        Console.Clear();
        int userRank = 600;
        string userName = "Uncle Tony";

        string rank = "";

        switch (userRank)
        {
            case 100:
            case 150:
                rank = "Iron";
                break;


            case 200:
                rank = "Bronze";
                break;


            case 300:
                rank = "Silver";
                break;


            case 400:
                rank = "Gold";
                break;


            case 500:
                rank = "Platinum";
                break;

            case 600:
                rank = "Diamond";
                break;


            case 700:
                rank = "Master";
                break;


            case 800:
                rank = "Grand-Master";
                break;


            case 900:
                rank = "Challenger";
                break;


            case 1000:
                rank = "God-Incarnate";
                break;

            default:
                rank = "tin";
                break;
        }

        Console.WriteLine($"{userName}, {rank}");
        Console.Read();
        TestingShit();
    }

    static void ForStart()
    {
        Console.Clear();
        for (int i = 0; i < 10; i ++)
        {
            Console.WriteLine(i);
        }
        Console.Read();
    }

    static void DoWhileStart()
    {
        Console.Clear();
        Random random = new Random();
        int current = 0;
        int timesTook = 0;
        int timesTookSix = 0;

        do
        {
            timesTook += 1;
            current = random.Next(1, 1001);
        } while (current != 777);
        do
        {
            timesTookSix += 1;
            current = random.Next(1, 1001);
        } while (current != 666);

        Console.WriteLine($"Rolls to get 777: {timesTook}");
        Console.WriteLine($"Rolls to get 666: {timesTookSix}");
        Console.Read();
    }
}