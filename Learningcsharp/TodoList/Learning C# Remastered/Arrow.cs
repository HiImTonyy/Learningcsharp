using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C__Remastered
{
    internal class Arrow
    {
        HeadType arrowhead;
        FletchingType fletching;
        public float length;
        public float cost;

        public Arrow(HeadType arrowhead, FletchingType fletching, float length)
        {
            this.arrowhead = arrowhead;
            this.fletching = fletching;
            this.length = length;
        }
        

        public void GetCost()
        {
            if (this.arrowhead == HeadType.steel) cost += 10;
            else if (this.arrowhead == HeadType.wood) cost += 3;
            else if (this.arrowhead == HeadType.obsidian) cost += 3;

            if (this.fletching == FletchingType.plastic) cost += 10;
            else if (this.fletching == FletchingType.turkey_feathers) cost += 5;
            else if (this.fletching == FletchingType.goose_feathers) cost += 3;

            cost += (this.length * 0.20f);
            return;
        }
        


        public enum HeadType {steel = 1, wood, obsidian, nullz}
        public enum FletchingType { plastic = 1, turkey_feathers, goose_feathers, nullz}
    }
}
