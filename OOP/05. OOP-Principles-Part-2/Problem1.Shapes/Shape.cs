namespace Problem1.Shapes
{
    public abstract class Shape
    {
        private decimal width;
        private decimal height;

        public Shape(decimal width, decimal height)
        {
            this.Width = width;
            this.Height = height;
        }

        public virtual decimal Width
        {
            get
            {
                return this.width;
            }

            set
            {
                this.width = value;
            }
        }

        public virtual decimal Height
        {
            get
            {
                return this.height;
            }

            set
            {
                this.height = value;

            }
        }

        public abstract decimal CalculateSurface();

    }
}