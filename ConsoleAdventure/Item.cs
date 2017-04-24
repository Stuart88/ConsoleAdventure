using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAdventure
{
    class Item
    {
        protected string name;
        protected int cost;
        protected int amount;
        protected int valueUp;

        public Item(string name, int cost, int amount, int value)
        {
            this.name = name;
            this.cost = cost;
            this.amount = amount;
            valueUp = value;
        }

        public void Use()
        {
            if (amount < 1)
            {
                Console.WriteLine("No {0} available.\n", name);
            }
                
            else
            {
                amount--;
            }
        }
        public int GetAmount()
        {
            return amount;
        }
        public void SetAmount(int amount)
        {
            this.amount = amount;
        }
        public int GetCost()
        {
            return cost;
        }
        
    }
}
