namespace DefiningClassesPart2
{
    using System;

    public struct Point3D
    {
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public decimal Z { get; set; }



        public Point3D(decimal xCoor = 0m, decimal yCoor = 0m, decimal zCoor = 0m)
        {
            this.X = xCoor;
            this.Y = yCoor;
            this.Z = zCoor;
        }



        public override string ToString()
        {
            return String.Format("[{0}][{1}][{2}]", this.X, this.Y, this.Z);
        }


    }
}
