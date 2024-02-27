namespace TodoList
{
    internal class DiceGame
    {
        public static void DiceStart()
        {
            Console.Clear();
            Random dice = new Random();

            int roll1 = dice.Next(1, 8);
            int roll2 = dice.Next(1, 8);
            int roll3 = dice.Next(1, 8);

            int total = roll1 + roll2 + roll3;
            /* roll1 = 0;
            roll2 = 0;
            roll3 = 0;*/ 

            Console.WriteLine($"Dice Roll: {roll1} + {roll2} + {roll3}");
            Console.WriteLine($"Your total is {total} and...");
            Console.ReadLine();
            Console.Clear();

            /* if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))                                                             (Having bonus points aren't fun but I'm keeping this part just for future reference.)
             {
                 if ((roll1 == roll2) && (roll2 == roll3))
                 {
                     total += 6;
                     Console.WriteLine("OHH BABY A TRIPLE, OHH YEAH! +6 TO THE TOTAL!");
                     Console.WriteLine($"Your total is now {total} and...");
                     Console.ReadLine();
                     Console.Clear();
                 }
                 else
                 {
                     total += 2;
                     Console.WriteLine("YOU GOT 2 DOUBLES! THAT'S A +2 BONUS TO THE TOTAL!");
                     Console.WriteLine($"Your total is now {total} and...");
                     Console.ReadLine();
                     Console.Clear();
                 } 

             }.*/

            if (roll1 == 5 && roll2 == 6 && roll3 == 7)
            {
                Console.WriteLine("If man is 5 and the devil is 6, then this must make me seven... THIS HONKEYS GOING TO HEAVEN!");
                Console.WriteLine("YOU'VE WON TICKETS TO SEE THE BAND 'THE BLOODHOUND GANG'!");
            }

            else if (roll1 == 6 && roll2 == 6 && roll3 == 6)
            {
                Console.WriteLine("You will regret ever opening this program.");
                Thread.Sleep(2000);
                DiceStart();
            }

            else if (roll1 == 3 && roll2 == 3 && roll3 == 3)
            {
                Console.WriteLine("Its only like... half evil, right?");
                Console.WriteLine("It's actually a powerful number, so... YOU JUST WON YOURSELF A VERY POWERFUL REAL-LIFE GORILLA!");
            }

            else if (roll1 == 7 && roll2 == 7 && roll3 == 7)
            {
                Console.WriteLine("Dude, your one lucky son of a bitch because... YOU'VE JUST WON YOURSELF 10,000 LOTTERY TICKETS!");
            }

            else if (roll1 == 0 && roll2 == 3 && roll3 == 3 || roll1 == 3 && roll2 == 3 && roll3 == 0)
            {
                Console.WriteLine("YOU'VE WON YOURSELF A GOLDEN COMPASS, A GOLDEN RAFTER SQUARE, AND THE LETTER G MADE FROM DIAMOND!");
                Console.ReadLine();
                DiceStart();
            }

            else if (roll1 == 0 && roll2 == 0 && roll3 == 0)
            {
                Console.WriteLine("Jesus dude... I wouldn't be surprised if a piano fell on you. \nunlucky man, you've won nothing :(");
            }

            if (roll1 == roll2 && roll2 == roll3)
            {
                Console.ReadLine();
                DiceStart();
            }

            if (total == 20) {
                Console.WriteLine("YOU'VE WON $1,000,000!!!");
            }

            else if (total >= 15)
            {
                Console.WriteLine("YOU'VE WON A BRAND NEW LAMBO!");
            }

            else if (total >= 8)
            {
                Console.WriteLine("YOU'VE WON A 1 WEEK LONG CRUISE AROUND EUROPE!");
            }

            else if (total >= 0)
            {
                Console.WriteLine("YOU'VE WON NOTHING!");
            }

            Console.ReadLine();
            DiceStart();
        }
    }
}