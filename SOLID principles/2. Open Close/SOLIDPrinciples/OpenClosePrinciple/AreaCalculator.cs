namespace OpenClosePrinciple
{
    public class AreaCalculator
    {
        public double CalculateArea(object shape)
        {
            if (shape is Circle)
            {
                Circle circle = (Circle)shape;
                return Math.PI * circle.Radius * circle.Radius;
            }
            else if (shape is Rectangle)
            {
                Rectangle rectangle = (Rectangle)shape;
                return rectangle.Width * rectangle.Height;
            }
            else
            {
                throw new ArgumentException("Shape not supported");
            }
        }
    }
}
