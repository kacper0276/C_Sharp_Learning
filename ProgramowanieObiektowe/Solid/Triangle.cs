namespace ProgramowanieObiektowe.Solid
{
    public class Triangle : Shape
    {
        public int SideA { get; set; }
        public int SideB { get; set; }
        public int SideC { get; set; }

        public override int Perimeter()
        {
            return SideA + SideB + SideC;
        }
    }
}
