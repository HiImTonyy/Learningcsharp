using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharpRemastered
{
    public class Arrow
    {
        public Arrowhead arrowhead
        {
            get { return arrowhead; }
            set { arrowhead = value; }
        }
        public FletchingType fletching
        {
            get { return fletching ; }
            set { fletching = value; }
        }

        public enum Arrowhead { steel = 1, wood, obsidian }
        public enum FletchingType { plastic = 1, turkey_feathers, goose_feathers }

        public static float GetCost(float number)
        {
            float cost = 0.05f * number;
            return cost;
        }

        public static Arrow CreateEliteArrow()
        {
            Arrowhead arrowhead = Arrowhead.steel;
            FletchingType fletching = FletchingType.plastic;
            float number = 95;
            Arrow arrow = new Arrow();
            return arrow;
        }
        public static Arrow CreateBeginnerArrow()
        {
            Arrowhead arrowhead = Arrowhead.wood;
            FletchingType fletching = FletchingType.goose_feathers;
            float number = 75;
            Arrow arrow = new Arrow();
            return arrow;
        }
        public static Arrow CreateMarksmanArrow()
        {
            Arrowhead arrowhead = Arrowhead.steel;
            FletchingType fletching = FletchingType.goose_feathers;
            float number = 65;
            Arrow arrow = new Arrow();
            return arrow;
        }
    }
}
