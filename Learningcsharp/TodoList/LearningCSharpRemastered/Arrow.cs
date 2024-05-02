using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharpRemastered

{

    public enum Arrowhead { steel = 1, wood, obsidian }

    public enum Fletching { plastic = 1, turkey_feathers, goose_feathers }
    internal class Arrow(Arrowhead arrowheadType, Fletching fletchingType, int length)
    {

        public enum Arrowhead { steel = 1, wood, obsidian }

        public enum Fletching { plastic = 1, turkey_feathers, goose_feathers }

        public string _arrowheadType;
        public string _fletchingType;
        public int _length;
        private Arrowhead selectedArrowhead;
        private Fletching selectedFletching;
        private float length;

        public Arrow(Arrowhead selectedArrowhead, Fletching selectedFletching, float length)
        {
            this.selectedArrowhead = selectedArrowhead;
            this.selectedFletching = selectedFletching;
            this.length = length;
        }

        public static void GetCost()
        {
            
        }
    }
}
