namespace DefiningClassesPart2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class StartUp
    {
        static void Main()
        {
            Point3D pointA = new Point3D(1,2,3);
            Point3D pointB = new Point3D(4,5,6);

            Console.WriteLine("Point A: "+ pointA);
            Console.WriteLine("Point B: " + pointB);
            Console.WriteLine("Point O: " + Point3D.O);

            Console.WriteLine(Calculate.Distance(pointA, pointB));

            Path path3D = new Path();

            path3D.Add(pointA);
            path3D.Add(pointB);
            path3D.Add(Point3D.O);

            Console.WriteLine("Print Path");
            Console.WriteLine(path3D);

            PathStorage.Save(path3D, "firstPath");

            Path second3DPath = PathStorage.Load("firstPath");

            Console.WriteLine("Print loaded path");
            Console.WriteLine(second3DPath);


        }
    }
}
