using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeMachine
{
    public abstract class Container
    {
        public int amount { get; private set; }
        public int maxAmount { get; }

        public Container(int max)
        {
            maxAmount = max;
        }
        public void PutObjectInContainer(int amount)
        {
            if (this.amount > maxAmount)
            {
                this.amount = maxAmount;
            }
            else
            {
                this.amount += amount;
            }
        }

        public int TakeObjectFromWaterContainer(int amount)
        {
            if (this.amount > amount)
            {
                this.amount -= amount;
                return amount;
            }

            int max = this.amount;
            this.amount = 0;
            return max;
        }
    }
}
