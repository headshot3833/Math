namespace mathTRiangle
{
    public interface ICircle
    {
        double CalculateArea(double radius);
    }
    public interface iTriangle
    {
        double CalculateArea(double a, double b, double c);
    }
    public class Circle : ICircle
    {
        public double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

    }
    public class Triangle : iTriangle
    {
        public double CalculateArea(double a, double b, double c) 
        {
            double S = (a + b + c)/2;

            return Math.Sqrt(S * (S - a) * (S - b) * (S - c));
        }
    }
}