using System;
using System.Text;

namespace Problem1
{
    public class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Verification.NullVerification(value);
                this.name = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

        public static void PrintPeople(Person man, Person woman)
        {
            Console.WriteLine("Man and woman data");
            Console.WriteLine(new string('-', 80));
            Console.WriteLine(man);
            Console.WriteLine(new string('-', 80));
            Console.WriteLine(woman);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"Name: {this.Name}");

            if (this.Age != null)
            {
                builder.AppendLine($"Age: {this.Age}");
            }
            else
            {
                builder.AppendLine($"Age: <not specified>");
            }

            return builder.ToString();
        }
    }
}
