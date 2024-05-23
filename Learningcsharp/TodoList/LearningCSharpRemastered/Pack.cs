using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharpRemastered
{
    public class Pack
    {
        public InventoryItem[] items;
        public int maxItems;
        public int maxWeight;
        public int maxVolume;
        public int currentItemCount;
        public int currentWeight;
        public int currentVolume;

        public Pack(int maxItems, int maxWeight, int maxVolume)
        {
            items = new InventoryItem[maxItems];
            this.maxItems = maxItems;
            this.maxWeight = maxWeight;
            this.maxVolume = maxVolume;
            currentItemCount = 0;
            currentWeight = 0;
            currentVolume = 0;
        }

        public bool Add(InventoryItem item)
        {
            if (currentItemCount + 1 > maxItems)
            {
                return false;
            }

            if (currentWeight + item.Weight > maxWeight)
            {
                return false;
            }

            if (currentVolume + item.Volume > maxVolume)
            {
                return false;
            }

            items[currentItemCount] = item;
            currentItemCount++;
            currentWeight += item.Weight;
            currentVolume += item.Volume;

            return true;
        }

        public int GetCurrentItemCount()
        {
            return currentItemCount;
        }

        public int GetCurrentWeight()
        {
            return currentWeight;
        }

        public int GetCurrentVolume()
        {
            return currentVolume;
        }

        public int GetMaxItems()
        {
            return maxItems;
        }

        public int GetMaxWeight()
        {
            return maxWeight;
        }

        public int GetMaxVolume()
        {
            return maxVolume;
        }
    }
}