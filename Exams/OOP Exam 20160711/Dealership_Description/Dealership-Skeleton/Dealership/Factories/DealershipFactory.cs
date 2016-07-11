using Dealership.Contracts;
using System;
using Dealership.Models;
using Dealership.Common.Enums;
using System.Collections.Generic;
using System.Text;

namespace Dealership.Factories
{
    public class DealershipFactory : IDealershipFactory
    {

        private IList<IVehicle> vehicleList;
        private IList<IUser> userList;

        public DealershipFactory()
        {
            vehicleList = new List<IVehicle>();
            userList = new List<IUser>();

        }

        public IVehicle CreateCar(string make, string model, decimal price, int seats)
        {
            return new Car(make, model, price, seats);
        }

        public IVehicle CreateMotorcycle(string make, string model, decimal price, string category)
        {
            return new Motorcycle(make, model, price, category);
        }

        public IVehicle CreateTruck(string make, string model, decimal price, int weightCapacity)
        {
            return new Truck(make, model, price, weightCapacity);
        }

        public IUser CreateUser(string username, string firstName, string lastName, string password, string role)
        {
            Boolean userExist = false;
            foreach (var item in this.userList)
            {
                if (item.Username.Equals(username)) userExist = true;
            }

            if (!userExist)
            {
                IUser result = new User(username, firstName, lastName, password, role);
                return result;
            }
            else
            {
                throw new ArgumentException("User {0} already exist.Choose a different username!", username);

            }


        }

        public override string ToString()
        {
            StringBuilder results = new StringBuilder();
            results.AppendLine("--USERS--");
            int counter = 1;
            foreach (var item in this.userList)
            {
                results.AppendLine(String.Format("{0}. {1}",counter++, item.ToString()));
            }

            return results.ToString();
        }



        public IComment CreateComment(string content)
        {
            return new Comment(content);
        }
    }
}
