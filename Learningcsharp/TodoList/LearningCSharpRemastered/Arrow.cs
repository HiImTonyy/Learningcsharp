using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharpRemastered
{
    public class Arrow
    {
        private Arrowhead _arrowhead;
        private FletchingType _fletching;
        private float _arrowLength;

        public enum Arrowhead { steel = 1, wood, obsidian }
        public enum FletchingType { plastic = 1, turkey_feathers, goose_feathers }

        public Arrow(Arrowhead arrowhead, FletchingType fletching, float length)
        {
            _arrowhead = arrowhead;
            _fletching = fletching;
            _arrowLength = length;
        }

        public static float GetCost(float number)
        {
            float cost = 0.05f * number;
            return cost;
        }
    }
}
