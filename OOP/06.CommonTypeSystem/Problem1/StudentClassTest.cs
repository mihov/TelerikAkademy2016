namespace Problem1
{
    using System;
    public class StudentClassTest
    {
        public static void TestOverriddenMethods()
        {
            Student firstStudent = new Student("Vasil", "Ivanov", "Kunchev", 1878, "bul. Vasil Levski 1", "levski@abv.bg", "0877777777", "IT", Specialties.WebDesign, Universities.SoftUni, Faculties.SoftDev);
            Student secondStudent = new Student("Hristo", "Botyov", "Petkov", 2233, "bul. Hr. Botev 24", "botev@gmail.bg", "0887766554", "Sport", Specialties.Running, Universities.NBU, Faculties.Sports);

            var equalStudents = firstStudent == secondStudent;
            var hashCode = firstStudent.GetHashCode();

            // Testing Equal()
            Console.WriteLine("\nFirst and second student are equal? -> {0}", equalStudents);
            Console.WriteLine(new string('-', 80));

            // Testing GetHashCode()
            Console.WriteLine("Hash code of first student -> " + hashCode);
            Console.WriteLine(new string('-', 80));

            // Printing Student
            Console.WriteLine(firstStudent);
            Console.WriteLine(new string('-', 80));

            // Changing the specialty on the cloning student doesnt affect the original firstStudent 
            var firstStudentCloning = firstStudent.Clone() as Student;
            firstStudentCloning.Faculty = Faculties.Sports;
            Console.WriteLine(firstStudentCloning);

            // Comparing students by first criteria -> Names, then by second criteria -> SS Number
            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Comparisson -> " + firstStudent.CompareTo(secondStudent) + Environment.NewLine);
            Console.WriteLine(new string('-', 80));
        }
    }
}

