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
    }
}
