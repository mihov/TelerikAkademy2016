namespace Problem1.Shapes
{
    using System;

    class StartUp
    {
        static void Main(string[] args)
        {
            Shape[] figures =
        {
            new Triangle(1,2),
            new Triangle(3,4),
            new Triangle(5,6),
            new Triangle(7,8),
            new Triangle(9,10),

            new Rectangle(1,2),
            new Rectangle(3,4),
            new Rectangle(5,6),
            new Rectangle(7,8),
            new Rectangle(9,10),

            new Square(2,2),
            new Square(4,4),
            new Square(6,6),
            new Square(8,8),
            new Square(10,10)
            //,new Square(9,10) // Un comment to test the exeption
        };

            foreach (Shape figure in figures)
            {
                Console.WriteLine(
                    "Figure = {0} \tsurface = {1:F2}",
                    figure.GetType().Name.PadRight(10, ' '),
                    figure.CalculateSurface());
            }
        }
    }
}
