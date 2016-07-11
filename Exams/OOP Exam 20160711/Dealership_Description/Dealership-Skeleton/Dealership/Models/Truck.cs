using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dealership.Common.Enums;
using Dealership.Contracts;
using Dealership.Common;

namespace Dealership.Models
{
    class Truck : Vehicle, ITruck
    {
        private int weightCapacity;

        public Truck(string make, string model, decimal price, int weightCapacity)
            : base(make, model, price, VehicleType.Truck)
        {
            this.WeightCapacity = weightCapacity;
        }
        public int WeightCapacity
        {
            get
            {
                return this.weightCapacity;
            }

            private set
            {

                Validator.ValidateIntRange(value, Constants.MinCapacity, Constants.MaxCapacity,
                                            String.Format(Constants.NumberMustBeBetweenMinAndMax,
                                            "Weight Capacity", Constants.MinCapacity, Constants.MaxCapacity));

                this.weightCapacity = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine(String.Format("  Weight Capacity: {0}t", this.WeightCapacity));

            return result.ToString();
        }
    }
}
