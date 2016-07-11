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
    public abstract class Vehicle : IVehicle
    {
        private IList<IComment> comments;
        private string make;
        private string model;
        private decimal price;
        private VehicleType vehicleType;
        private int wheels;

        public Vehicle(string make, string model, decimal price, VehicleType vehicleType)
        {
            this.comments = new List<IComment>();
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.Type = vehicleType;
        }

        public IList<IComment> Comments
        {
            get
            {
                return this.comments;
            }


        }

        public string Make
        {
            get
            {
                return this.make;
            }

            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinMakeLength, Constants.MaxMakeLength,
                             String.Format(Constants.StringMustBeBetweenMinAndMax,
                            "Make", Constants.MinMakeLength, Constants.MaxMakeLength));
                this.make = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinModelLength, Constants.MaxModelLength,
                             String.Format(Constants.StringMustBeBetweenMinAndMax,
                            "Model", Constants.MinModelLength, Constants.MaxModelLength));
                this.model = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                Validator.ValidateDecimalRange(value, Constants.MinPrice, Constants.MaxPrice,
                             String.Format(Constants.NumberMustBeBetweenMinAndMax,
                            "Price", Constants.MinPrice, Constants.MaxPrice));
                this.price = value;
            }
        }

        public VehicleType Type
        {
            get
            {
                return this.vehicleType;
            }
            private set
            {
                this.vehicleType = value;
            }
        }

        public int Wheels
        {
            get
            {
                return this.wheels;
            }

            private set
            {
                this.wheels = (int)Type;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(String.Format("  Make: {0}", this.Make));
            result.AppendLine(String.Format("  Model: {0}", this.Model));
            result.AppendLine(String.Format("  Wheels: {0}", this.Wheels));
            result.AppendLine(String.Format("  Price: ${0}", this.Price));

            result.Length -= 2;
            return result.ToString();
        }

        public void AddComment(IUser user, String content)
        {
            this.comments.Add(new Comment(content, user));
        }

    }
}
