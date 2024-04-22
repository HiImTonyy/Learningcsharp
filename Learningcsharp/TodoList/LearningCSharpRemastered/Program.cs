class Program
{

    static bool methodInfoGoBack = false;
    public static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.SetWindowSize(180, 51);
            Console.WriteLine("Hey dude, what task do you wanna check out?");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("NOTE: If you want to know the objective / info of any given task, then type in 'info'.\n");
            Console.ResetColor();

            Console.WriteLine("0) Hello World!\n");

            if (methodInfoGoBack)
                MethodInfo();
            string input = Console.ReadLine();

            switch (input)
            {
                case "0":
                    HelloWorld();
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

    // ------ MISC STUFF ------ MISC STUFF ------ MISC STUFF ------ MISC STUFF ------- MISC STUFF ------ MISC STUFF ------

    static void MethodInfo()
    {
        while(true)
        {
            int inputNumber;
            string selectedInfoNumber;

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine("Type in the task number to check the info.\n");

            string input = Console.ReadLine();
            int.TryParse(input, out inputNumber);

            List<string> infolist = new List<string>();
            {
                infolist.Add("Create a new Hello World program. (yeah, that's it.)");
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
                Console.WriteLine($"\nOBJECTIVE(S): {selectedInfoNumber}\n");
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
                else
                {
                    Console.ResetColor();
                    methodInfoGoBack = false;
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
        Console.ForegroundColor = ConsoleColor.Magenta;

        Console.WriteLine("\nEnd of task, please press enter to exit current task.");
        Console.ReadLine();
        Console.ResetColor();
    }
}