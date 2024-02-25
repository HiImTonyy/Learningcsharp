using Microsoft.VisualBasic;
using System.Buffers;
using System.Diagnostics.CodeAnalysis;

class Calculator
{
    static void Main()
    {
        string userChoice = null;
        Console.Clear();
        Console.WriteLine($"Hey my dude, you wanna add, subtract, divide, or multiply a number?\n");
        Console.Write("Input: ");
        string input = Console.ReadLine();

        switch (input)
        {
            case "add":
                userChoice = "add";
                Operations(userChoice);
                break;
            case "subtract":
                userChoice = "subtract";
                Operations(userChoice);
                break;
            case "divide":
                userChoice = "divide";
                Operations(userChoice);
                break;
            case "multiply":
                userChoice = "multiply";
                Operations(userChoice);
                break;

            default:
                Main();
                break;
        }

        void Operations(string userChoice)
        {
            Console.Clear();
            Console.WriteLine($"So you wanna {userChoice} eh? I've got you covered. What is the first number you want to {userChoice}?");
            string userOperationOne = Console.ReadLine();
            {
                bool parseFail = int.TryParse(userOperationOne, out int firstNumber);

                if (!parseFail)
                {
                    Operations(userChoice);
                }
                else
                {
                    OperationsTwo(userChoice, firstNumber);
                }
            }
            void OperationsTwo(string userChoice, int firstNumber)
            {
                Console.Clear();
                Console.WriteLine("Cool.. Cool. what about the Second number?");
                string userOperationTwo = Console.ReadLine();
                {
                    bool parseFail = int.TryParse(userOperationTwo, out int secondNumber);

                    if (!parseFail)
                    {
                        OperationsTwo(userChoice, firstNumber);
                    }
                    else
                    {
                        Console.WriteLine("TWO");
                        Console.ReadLine();
                        Whatever(userChoice, firstNumber, secondNumber);
                    }
                }
            }
        }
        void Whatever(string userChoice, int firstNumber, int secondNumber)
        {
            Console.Clear();
            Console.WriteLine($"First: {firstNumber} second: {secondNumber}");
            Console.ReadLine();
        }
    }
}
