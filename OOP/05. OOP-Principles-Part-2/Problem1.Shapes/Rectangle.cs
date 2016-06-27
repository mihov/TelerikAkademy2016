namespace Problem1.Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(decimal width, decimal height) : base(width, height)
        {

        }
        public override decimal CalculateSurface()
        {
            return this.Height * this.Width;
        }
    }
}