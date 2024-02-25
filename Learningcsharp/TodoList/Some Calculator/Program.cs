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
            Console.WriteLine($"So you wanna {userChoice} eh? I've got you covered. What is the first number you want to {userChoice}?\n");
            Console.Write("Input: ");
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
                Console.WriteLine("Cool.. Cool. what about the Second number?\n");
                Console.Write("Input: ");
                string userOperationTwo = Console.ReadLine();
                {
                    bool parseFail = int.TryParse(userOperationTwo, out int secondNumber);

                    if (!parseFail)
                    {
                        OperationsTwo(userChoice, firstNumber);
                    }
                    else
                    {
                        Calculation(userChoice, firstNumber, secondNumber);
                    }
                }
            }
        }
        void Calculation(string userChoice, int firstNumber, int secondNumber)
        {
            int result = 5378008;
            switch (userChoice)
            {
                case "add":
                    Console.Clear();
                    result = firstNumber + secondNumber;
                    Console.WriteLine($"Answer: {firstNumber} + {secondNumber} = {result}");
                    Console.ReadLine();
                    Main();
                    break;
                case "subtract":
                    Console.Clear();
                    result = firstNumber - secondNumber;
                    Console.WriteLine($"Answer: {firstNumber} - {secondNumber} = {result}");
                    Console.ReadLine();
                    Main();
                    break;
                case "divide":
                    Console.Clear();
                    decimal divResult = (decimal)firstNumber / secondNumber;
                    Console.WriteLine($"Answer: {firstNumber} / {secondNumber} = {divResult}");
                    Console.ReadLine();
                    Main();
                    break;
                case "multiply":
                    Console.Clear();
                    result = firstNumber * secondNumber;
                    Console.WriteLine($"Answer: {firstNumber} * {secondNumber} = {result}");
                    Console.ReadLine();
                    Main();
                    break;

            }
        }
    }
}