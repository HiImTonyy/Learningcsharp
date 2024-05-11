using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharpRemastered
{
    public class Card
    {

        public enum CardColor { red = 1, green, blue, yellow }
        public enum CardRank { one = 1, two, three, four, five, six, seven, eight, nine, ten }

        public CardRank rank { get; }
        public CardColor color { get; }

        public Card()
        {

        }

        public Card(CardColor color, CardRank rank)
        {
            color = color;
            rank = rank;
        }

        public static void CardCheck(string card)    //I'm unsure of why the book said to make this.. it says to make one, but doesn't say that you need to use it.
        {
            if ((int)CardColor.red > 0)
            {
                card = "colored";
                return;
            }
            else
            {
                card = "numbered";
                return;
            }
        }
        public static CardColor red { get; } = CardColor.red;
        public static CardColor green { get; } = CardColor.green;
        public static CardColor blue { get; } = CardColor.blue;
        public static CardColor yellow { get; } = CardColor.yellow;
        public static CardRank one { get; } = CardRank.one;
        public static CardRank two { get; } = CardRank.two;
        public static CardRank three { get; } = CardRank.three;
        public static CardRank four { get; } = CardRank.four;
        public static CardRank five { get; } = CardRank.five;
        public static CardRank six { get; } = CardRank.six;
        public static CardRank seven { get; } = CardRank.seven;
        public static CardRank eight { get; } = CardRank.eight;
        public static CardRank nine { get; } = CardRank.nine;
        public static CardRank ten { get; } = CardRank.ten;
    }
}