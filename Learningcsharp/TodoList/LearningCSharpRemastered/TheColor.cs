using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharpRemastered
{
    internal class TheColor
    {
        public class Color
        {
            public int red {get; set;}
            public int green { get; set;}
            public int blue { get; set;}

            public Color()
            {

            }

            public Color(int red, int  green, int blue)
            {
                this.red = red;
                this.green = green;
                this.blue = blue;
            }

            public static Color White { get; } = new Color(255, 255, 255);
            public static Color Black { get; } = new Color(0, 0, 0);
            public static Color Red { get; } = new Color(255, 0, 0);
            public static Color Orange { get; } = new Color(255, 165, 0);
            public static Color Yellow { get; } = new Color(255, 255, 0);
            public static Color Green { get; } = new Color(0, 128, 0);
            public static Color Blue { get; } = new Color(0, 0, 255);
            public static Color Purple { get; } = new Color(128, 255, 128);
        }
    }
}
