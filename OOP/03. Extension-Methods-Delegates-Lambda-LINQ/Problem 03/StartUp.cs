using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var students = Student.StudentsInfo();

            Console.WriteLine("\nProblem 3. First before last");
            var sortedByLastName = StudentsSorting.LastNameBiggerThanFirstName(students);
            Student.Print(sortedByLastName);
            //--------------------------------------------------------------------------------------------------------
            Console.WriteLine("\nProblem 4. Age range");
            var sortedByAge = StudentsSorting.AgeRange(students);
            Student.Print(sortedByAge);
            //--------------------------------------------------------------------------------------------------------

            Console.WriteLine("\nProblem 5. Order students");
            var sortedByBothNames = StudentsSorting.SortByFirstAndLastName(students);
            Student.Print(sortedByBothNames);
            //--------------------------------------------------------------------------------------------------------

            Console.WriteLine("\nProblem 6. Divisible by 7 and 3");
            var numbers = Enumerable.Range(3, 100);
            StudentsSorting.SortNumbers(numbers);
            //--------------------------------------------------------------------------------------------------------

            Console.WriteLine("\nProblem 9. Student groups");
            StudentsSorting.GroupByGroupNumber(students);
            //--------------------------------------------------------------------------------------------------------

            Console.WriteLine("\nProblem 10. Student groups extensions");
            var result = students.GroupStudents();
            result.PrintData();
            //--------------------------------------------------------------------------------------------------------

            Console.WriteLine("\nProblem 11. Extract students by email (@abv.bg)");
            StudentsSorting.GroupByEmail(students);
            //--------------------------------------------------------------------------------------------------------

            Console.WriteLine("\nProblem 12. Extract students by phone from  Sofia");
            StudentsSorting.StudentsWithPhones(students);
            //--------------------------------------------------------------------------------------------------------

            Console.WriteLine("\nProblem 13. Extract students by marks");
            var anonArray = new[]
            {
                new { FullName = "Georgi Kokov", Marks = new List<int> { 2, 4, 5, 4, 2} },
                new { FullName = "Shoko Mokov", Marks = new List<int> { 2, 2, 4, 3, 6} },
                new { FullName = "Zaio Baio", Marks = new List<int> { 5, 6, 5, 4, 3} },
                new { FullName = "Mimo Pitona", Marks = new List<int> { 4, 5, 4, 6, 6} }
            };

            var studentsWith6 = anonArray
                .Where(x => x.Marks.Contains(6))
                .ToArray();

            foreach (var item in studentsWith6)
            {
                Console.WriteLine($"{item.FullName} -> Marks: {string.Join(" ", item.Marks)}");
            }
            //--------------------------------------------------------------------------------------------------------

            Console.WriteLine("\nProblem 14. Extract students with two marks");
           var studentsWith2 = anonArray
               .Where(x => x.Marks
                   .Where(m => m == 2)
                   .Count() == 2)
               .ToArray();
            foreach (var item in studentsWith2)
            {
                Console.WriteLine($"{item.FullName} -> Marks: {string.Join(" ", item.Marks)}");
            }
            //--------------------------------------------------------------------------------------------------------

            Console.WriteLine("\nProblem 15. Extract marks 2006");
            StudentsSorting.MarksFrom2006(students);

            //--------------------------------------------------------------------------------------------------------
            Console.WriteLine("\nProblem 16.* Groups");
            StudentsSorting.MathStudents(students);
            //--------------------------------------------------------------------------------------------------------

            Console.WriteLine("\nProblem 17. Longest string");
            var stringArray = new string[] { "alabala", "blalvala", "thisisprobablythelongeststring", "else" };
            StudentsSorting.LongestString(stringArray);

            Console.WriteLine("\nProblem 18. Grouped by GroupNumber");
            StudentsSorting.SortStudentsByGroupNumber(students);

            //--------------------------------------------------------------------------------------------------------
            Console.WriteLine("\nProblem 19. Grouped by GroupName extensions");
            students.GroupNumberSort();
        }
    }
}
