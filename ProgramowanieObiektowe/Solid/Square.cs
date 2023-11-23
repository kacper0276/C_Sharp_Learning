namespace ProgramowanieObiektowe.Solid
{
    public class Square : Shape
    {
        public int Side { get; set; }

        public override int Perimeter()
        {
            return 4 * Side;
        }
    }
}
