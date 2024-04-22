class Program
{
     static void Main()
    {
        Console.Clear();
        Console.SetWindowSize(180, 51);
        Console.WriteLine("Hey dude, what do you wanna do?\n");

        Console.WriteLine("1) Whatever");

        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Test();
                break;
        }

        static void Test()
        {
            Console.Clear();
            Console.WriteLine("Hey! stop right there criminal scum!");
            Console.ReadLine();
            Main();
        }
    }
}