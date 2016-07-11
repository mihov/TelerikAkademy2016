using Dealership.Common;
using Dealership.Common.Enums;
using Dealership.Contracts;
using System;
using System.Text;

namespace Dealership.Models
{
    public class Car : Vehicle, ICar
    {
        private int seats;

        public Car(string make, string model, decimal price, int seats)
                        : base(make, model, price, VehicleType.Car)
        {
            this.Seats = seats;

        }

        public int Seats
        {
            get
            {
                return this.seats;
            }

            private set
            {
                Validator.ValidateIntRange(value, Constants.MinSeats, Constants.MaxSeats,
                             String.Format(Constants.NumberMustBeBetweenMinAndMax,
                            "Seats", Constants.MinSeats, Constants.MaxSeats));

                this.seats = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine(String.Format("  Seats: {0}",this.Seats));

            return result.ToString();
        }




    }
}
