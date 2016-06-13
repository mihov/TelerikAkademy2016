
namespace DefiningClassesPart2
{
    public static class Calculate
    {
        public static decimal Distance(Point3D pointA, Point3D pointB)
        {
            return (pointA.X - pointB.X) * (pointA.X - pointB.X) +
                   (pointA.Y - pointB.Y) * (pointA.Y - pointB.Y) +
                   (pointA.Z - pointB.Z) * (pointA.Z - pointB.Z);
        }
    }
}
