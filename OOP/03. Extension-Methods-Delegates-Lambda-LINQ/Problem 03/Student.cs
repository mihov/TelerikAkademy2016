using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03
{
    public class Student
    {
        public Student(string firstName, string lastName, int age, string fn, string tel, string email
            , List<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }


        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}";
        }

        public static void Print(Student[] studentList)
        {
            foreach (var item in studentList)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
        }

        public static Student[] StudentsInfo()
        {
            var result = new Student[4];
            result[0] = new Student("Stefan", "Ranov", 17, "12340615", "+359285236441", "Stefan.Ivanov@abv.bg", new List<int> { 5, 4, 5, 3, 2 }, 2);
            result[1] = new Student("Vasil", "Petkov", 18, "12340725", "+3593095444441", "Vasil.Petkov@mail.bg", new List<int> { 3, 5, 6, 5, 4, 3 }, 3);
            result[2] = new Student("Kolio", "Zeorgoev", 23, "12340666", "+3592875123441", "Kolio.Georgiev@abv.bg", new List<int> { 3, 4, 5, 6, 3, 4 }, 2);
            result[3] = new Student("Stefan", "Kolev", 27, "12340633", "+359485777444", "Stefan.Kolev@abv.com", new List<int> { 4, 6, 3, 5, 3, 5 }, 1);
            return result;
        }
    }
}
