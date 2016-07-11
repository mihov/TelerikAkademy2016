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
    class User : IUser
    {
        private string firstName;
        private string lastName;
        private string password;
        private Role role;
        private string username;
        private IList<IVehicle> vehicles;

        public User(string username, string firstName, string lastName, string password, string role)
        {
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.Role = (Role)Enum.Parse(typeof(Role), role);

            vehicles = new List<IVehicle>();
        }


        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinNameLength, Constants.MaxNameLength,
                         String.Format(Constants.StringMustBeBetweenMinAndMax,
                        "Firstname", Constants.MinNameLength, Constants.MaxNameLength));

                this.firstName = value;
            }


        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinNameLength, Constants.MaxNameLength,
                         String.Format(Constants.StringMustBeBetweenMinAndMax,
                        "Lastname", Constants.MinNameLength, Constants.MaxNameLength));

                this.lastName = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }

            private set
            {
                Validator.ValidateSymbols(value, Constants.UsernamePattern, String.Format(Constants.InvalidSymbols, "Password"));

                Validator.ValidateIntRange(value.Length, Constants.MinPasswordLength, Constants.MaxPasswordLength,
                         String.Format(Constants.StringMustBeBetweenMinAndMax,
                        "Password", Constants.MinPasswordLength, Constants.MaxPasswordLength));
                this.password = value;
            }
        }

        public Role Role
        {
            get
            {
                return this.role;
            }

            private set
            {
                if (Enum.IsDefined(typeof(Role), value))
                {
                    this.role = value;
                }
                else
                {
                    throw new ArgumentException("Enter correct Role");
                }
            }
        }

        public string Username
        {
            get
            {
                return this.username;
            }

            private set
            {
                Validator.ValidateIntRange(value.Length, Constants.MinNameLength, Constants.MaxNameLength,
                         String.Format(Constants.StringMustBeBetweenMinAndMax,
                        "Username", Constants.MinNameLength, Constants.MaxNameLength));

                Validator.ValidateSymbols(value, Constants.UsernamePattern, String.Format(Constants.InvalidSymbols, "Username"));

                this.username = value;
            }
        }

        public IList<IVehicle> Vehicles
        {
            get
            {
                return this.vehicles;
            }
        }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            if (this.vehicles.Contains(vehicleToAddComment))
            {
                int position = this.vehicles.IndexOf(vehicleToAddComment);

                Validator.ValidateNull(commentToAdd, Constants.CommentCannotBeNull);
                this.vehicles[position].Comments.Add(commentToAdd);
            }

            else
            {
                throw new ArgumentException("The vehicle does not exist!");
            }
        }

        public void AddVehicle(IVehicle vehicle)
        {
            Validator.ValidateNull(vehicle, Constants.VehicleCannotBeNull);

            if (this.Role == Role.Admin) throw new ArgumentException("You are an admin and therefore cannot add vehicles!");

            if (this.Role != Role.VIP && this.vehicles.Count > Constants.MaxVehiclesToAdd) throw new ArgumentException("You are not VIP and cannot add more than 5 vehicles!");

            if (!this.vehicles.Contains(vehicle))
            {
                this.vehicles.Add(vehicle);
            }
            else
            {
                throw new ArgumentException("This Vehicle already exist!");
            }

        }

        public string PrintVehicles()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(String.Format("--USER {0}--",this.username));

            if (this.Vehicles.Count < 1)
            {
                result.AppendLine("--NO VEHICLES--");
            }
            else
            {
                foreach (var item in this.Vehicles)
                {
                    result.AppendLine(item.ToString());
                }
            }
            
            return result.ToString();
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            if (this.vehicles.Contains(vehicleToRemoveComment))
            {
                int position = this.vehicles.IndexOf(vehicleToRemoveComment);

                Validator.ValidateNull(commentToRemove, Constants.CommentCannotBeNull);
                if (commentToRemove.Author == this.Username)
                {
                    this.vehicles[position].Comments.Remove(commentToRemove);
                }
                else
                {
                    throw new ArgumentException("You are not the author!");
                }
                
                
            }
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            Validator.ValidateNull(vehicle, Constants.VehicleCannotBeNull);
            if (this.vehicles.Contains(vehicle))
            {
                this.vehicles.Remove(vehicle);
            }

            else
            {
                throw new ArgumentException("The vehicle does not exist!");
            }

        }

        public override string ToString()
        {
            return String.Format("Username: {0}, FullName: {1} {this.LastName}, Role: {2}", this.Username, this.FirstName, this.Role);
        }
    }
}
