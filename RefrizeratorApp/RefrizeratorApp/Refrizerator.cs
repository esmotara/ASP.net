using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrizeratorApp
{
    class Refrizerator
    {
        private double capacity=0;
       // public double weight;
        private double currentWeight=0;
        private double remainingWeight=0;

        public double Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public double CurrentWeight
        {
            get { return currentWeight; }
        }

        public double RemainingWeight
        {
            get { return remainingWeight; }
        }


        public void AddItems(int noOfItems, double weightPerItem)
        {
            if (CurrentWeight + weightPerItem <= Capacity)
            {
                currentWeight = CurrentWeight + noOfItems * weightPerItem;
                remainingWeight = Capacity - CurrentWeight;
            }
            else
            {
                throw new Exception("Overload.....");
            }
        }
    }
}
