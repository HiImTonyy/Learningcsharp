﻿Console.WriteLine("Hey dude, what do you wanna do?\n");

Console.WriteLine("1) See all lists");
Console.WriteLine("2) Add item to list");
Console.WriteLine("3) Remove item from list");
Console.WriteLine("4) Exit");

var letterCount = 0;
var userChoice = Console.ReadLine();

if (userChoice == "ABC")
{
    letterCount = userChoice.Length;
    Console.WriteLine("User knows his abc's!");
    var UserChooseLength = Console.ReadLine();
}
else
{
    Console.WriteLine("Someone gave their 2 year old a computer...");
}

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

Console.ReadKey();