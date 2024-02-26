namespace TodoList
{
    internal class DiceGame
    {
        public static void DiceStart()
        {
            Console.Clear();
            Random dice = new Random();

            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);

            int total = roll1 + roll2 + roll3;

            Console.WriteLine($"Dice Roll: {roll1} + {roll2} + {roll3}");
            Console.WriteLine($"Your total is {total} and...");
            Console.ReadLine();
            Console.Clear();

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    Console.WriteLine("OHH BABY A TRIPLE, OHH YEAH! +6 TO THE TOTAL!");
                    Console.WriteLine($"Your total is now {total} and...");
                    total += 6;
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("YOU GOT 2 DOUBLES! THAT'S A +2 BONUS TO THE TOTAL!");
                    Console.WriteLine($"Your total is now {total} and...");
                    total += 2;
                    Console.ReadLine();
                    Console.Clear();
                }

            }

            if (roll1 == 5 && roll2 == 6 && roll3 == 7)
            {
                Console.WriteLine("If man is 5 and the devil is 6, then this must make me seven... THIS HONKEYS GOING TO HEAVEN!");
                Console.WriteLine("YOU'VE WON TICKETS TO SEE THE BAND 'THE BLOODHOUND GANG'!");
            }

            Console.ReadLine();
            DiceStart();
        }
    }
}