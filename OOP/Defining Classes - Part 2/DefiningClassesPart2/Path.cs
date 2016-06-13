

namespace DefiningClassesPart2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Path
    {
        private List<Point3D> pointList;

        public Path()
        {
            this.pointList = new List<Point3D>();
        }

        public void Add(Point3D thePoint)
        {
            this.pointList.Add(thePoint);
        }

        public int Count
        {
            get
            {
                return this.pointList.Count;
            }
        }

        public Point3D this[int index]
        {
            get { return this.pointList[index]; }
            set { this.pointList[index] = value; }
        }

        public override string ToString()
        {
            StringBuilder listOfPoints = new StringBuilder();

            foreach (var item in this.pointList)
            {
                listOfPoints.AppendLine(item.ToString());
            }

            return listOfPoints.ToString();
        }
    }
}
