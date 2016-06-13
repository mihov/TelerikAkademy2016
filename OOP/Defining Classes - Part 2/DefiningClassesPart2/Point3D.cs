namespace DefiningClassesPart2
{
    using System;

    public struct Point3D
    {
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public decimal Z { get; set; }

        private static readonly Point3D Start = new Point3D(0, 0, 0);

        public Point3D(decimal xCoor = 0m, decimal yCoor = 0m, decimal zCoor = 0m)
        {
            this.X = xCoor;
            this.Y = yCoor;
            this.Z = zCoor;
        }

        public static Point3D O
        {
            get { return Start; }
        }

        public override string ToString()
        {
            return string.Format("[{0}:{1}:{2}]", this.X, this.Y, this.Z);
        }
    }
}
