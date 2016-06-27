namespace Problem1.Shapes
{
    public class Triangle : Shape
    {
        public Triangle(decimal width, decimal height) : base(width, height)
        {
        }

        public override decimal CalculateSurface()
        {
            return this.Height * this.Width / 2m;
        }
    }
}