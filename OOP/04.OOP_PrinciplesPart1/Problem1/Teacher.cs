using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem1
{
    public class Teacher:People
    {
        private List<Discipline> disciplines;

        public Teacher(String name):base(name)
        {
          this.disciplines = new List<Discipline>();
        }



        public void AddDiscipline(Discipline discip)
        {
            this.disciplines.Add(discip);
        }

        public bool RemoveDiscipline(Discipline discip)
        {
           
               return this.disciplines.Remove(discip);
           
        }

        public String PrintDisciplines()
        {
            StringBuilder result = new StringBuilder();
            foreach (var discipline in this.disciplines)
            {
                result.AppendLine(discipline.ToString());
            }
            return result.ToString();

        }

   
    }
}