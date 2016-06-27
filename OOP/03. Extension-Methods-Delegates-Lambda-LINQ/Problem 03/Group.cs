using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03
{
   public class Group
    {

        private static List<Group> groups = new List<Group>()
        {
            new Group(1, "Marine Biology"),
            new Group(2, "Computer Science"),
            new Group(3, "Paramedical Science"),
            new Group(4, "Psychology")
        };


        public Group(int grpNumber, string depName)
        {
            this.GroupNumber = grpNumber;
            this.DepartmentName = depName;
        }

        public static List<Group> Groups
        {
            get
            {
                return groups;
            }
        }

        public int GroupNumber { get; set; }
        public string DepartmentName { get; set; }

    }
}
