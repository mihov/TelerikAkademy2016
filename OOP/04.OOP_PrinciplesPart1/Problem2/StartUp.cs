using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ================ Students List ================ ");
            List<Student> studensList = new List<Student>(10);
            studensList.Add(new Student("Ivan", "Ivanov"));
            studensList.Add(new Student("Vasil", "Kolev"));
            studensList.Add(new Student("Emil", "Hristov"));
            studensList.Add(new Student("Rangel", "Lalov"));
            studensList.Add(new Student("Asen", "Penev"));
            studensList.Add(new Student("Zarko", "Agov"));
            studensList.Add(new Student("Pavel", "Cherne"));
            studensList.Add(new Student("Stefan", "Kirch"));
            studensList.Add(new Student("Niki", "Stoyano"));
            studensList.Add(new Student("Vasko", "Sabin"));

            for (int i = 0; i < studensList.Count; i++)
            {
                studensList[i].Grade = (2 + (i % 5));
                Console.WriteLine((i + 1) + ". " + studensList[i].FirstName + " " + studensList[i].LastName + "\t\t" + studensList[i].Grade);
            }

            var studensList2 = studensList
                .OrderBy(x => x.Grade)
                .ToArray();

            Console.WriteLine("\nSorted Student List");
            for (int i = 0; i < studensList2.Length; i++)
            {

                Console.WriteLine((i + 1) + ". " + studensList2[i].FirstName + " " + studensList2[i].LastName + "\t\t" + studensList2[i].Grade);
            }



            Console.WriteLine("\n\n ================ Worker List ================ ");
            List<Worker> workerList = new List<Worker>(10);
            workerList.Add(new Worker("KIro", "Ivanov"));
            workerList.Add(new Worker("Vania", "Kolev"));
            workerList.Add(new Worker("Ele", "Hristov"));
            workerList.Add(new Worker("Ross", "Lalov"));
            workerList.Add(new Worker("Adem", "Penev"));
            workerList.Add(new Worker("Rich", "Agov"));
            workerList.Add(new Worker("Pool", "Chochi"));
            workerList.Add(new Worker("Simon", "Kris"));
            workerList.Add(new Worker("Niko", "Stef"));
            workerList.Add(new Worker("Veli", "Sole"));

            for (int i = 0; i < workerList.Count; i++)
            {
                workerList[i].WorkHoursPerDay = 4 + i % 5;
                workerList[i].WeekSalary = 100 + 100 * (i % 4) * i / 2;
                Console.WriteLine((i + 1) + ". " + workerList[i].FirstName + " " + workerList[i].LastName + "\t" + workerList[i].WorkHoursPerDay + "h\t$" + workerList[i].WeekSalary);
            }

            var workerList2 = workerList
                            .OrderByDescending(x => x.MoneyPerHour())
                            .ToArray();

            Console.WriteLine("\nSorted List");
            for (int i = 0; i < workerList2.Length; i++)
            {

                Console.WriteLine((i + 1) + ". " + workerList2[i].FirstName + " " + workerList2[i].LastName + "\t" + workerList2[i].WorkHoursPerDay + "h\t$" + workerList2[i].WeekSalary+ "\t$" + workerList2[i].MoneyPerHour().ToString("#.##"));
            }


            List<Human> listAll = new List<Human>();
            listAll.AddRange(studensList2);
            listAll.AddRange(workerList2);

           Console.WriteLine("\n============== List of All ==================");
            for (int i = 0; i < listAll.Count; i++)
            {

                Console.WriteLine((i + 1) + ". " + listAll[i].FirstName + " " + listAll[i].LastName );
            }



            var listAll2 = listAll
                    .OrderBy(x => x.FirstName)
                    .ThenBy(x => x.LastName)
                    .ToArray();

           Console.WriteLine("\n============== List of All Sorted ==================");
            for (int i = 0; i < listAll2.Length; i++)
            {

                Console.WriteLine((i + 1) + ". " + listAll2[i].FirstName + " " + listAll2[i].LastName );
            }

        }
    }
}
