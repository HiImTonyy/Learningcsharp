using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharpRemastered
{
    public class InventoryItem
    {
        public int Weight { get; set; }
        public int Volume { get; set; }

        public InventoryItem(int weight, int volume)
        {
            this.Weight += weight;
            this.Volume += volume;
        }

        public InventoryItem() : this(0, 0)
        {
        }
    }

    public class Arroww : InventoryItem
    {
        public Arroww() : base(1, 3)
        {
            return;
        }
    }

    public class Bow : InventoryItem
    {
        public Bow() : base(3, 6)
        {
            return;
        }
    }

    public class Rope : InventoryItem
    {
        public Rope() : base(1, 3)
        {
            return;
        }
    }

    public class Water : InventoryItem
    {
        public Water() : base(1, 4)
        {
            return;
        }
    }

    public class Food : InventoryItem
    {
        public Food() : base(1, 2)
        {
            return;
        }
    }

    public class Sword : InventoryItem
    {
        public Sword() : base(12, 5)
        {
            return;
        }
    }
}
