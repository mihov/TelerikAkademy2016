using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem1
{
    public class School : HasName
    {
        private List<StudentClass> studentClasses;



        public School(String name) : base(name)
        {
            studentClasses = new List<StudentClass>();
        }

        public void AddClass(StudentClass value)
        {
            this.studentClasses.Add(value);
        }

        public bool RemoveClass(StudentClass value)
        {
            return this.studentClasses.Remove(value);
        }

        public String PrintClass()
        {
            StringBuilder result = new StringBuilder();
            foreach (var discipline in this.studentClasses)
            {
                result.AppendLine(discipline.ToString());
            }
            return result.ToString();
        }
    }
}