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
    public class Motorcycle : Vehicle, IMotorcycle
    {
        private string category;

        public Motorcycle(string make, string model, decimal price, string category)
            : base(make, model, price, VehicleType.Motorcycle)
        {
            this.Category = category;
        }

        public string Category
        {
            get
            {
                return this.category;
            }

            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinCategoryLength, Constants.MaxCategoryLength,
                                             String.Format(Constants.StringMustBeBetweenMinAndMax,
                                            "Category", Constants.MinCategoryLength, Constants.MaxCategoryLength));

                this.category = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine(String.Format("  Category: {0}", this.Category));

            return result.ToString();
        }
    }
}
