namespace Problem1.Shapes
{
    using System;
    public class Square : Rectangle
    {
        public Square(decimal width, decimal height) : base(width, height)
        {
            if (this.Height != this.Width) throw new ArgumentException("Square must have equal height and width!");
        }
    }
}