namespace ProgramowanieObiektowe.Solid
{
    public class PerimeterCalculator
    {
        public int Calculate(Shape shape)
        {
            return shape.Perimeter();
        }
    }
}
