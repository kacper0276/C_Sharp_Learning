namespace ProgramowanieObiektowe.Kompozycja_A_Dziedziczenie
{
    public class Butterfly
    {
        private readonly FlyingAnimal _flyingAnimal;
        public Butterfly(FlyingAnimal flyingAnimal, string name)
        {
            _flyingAnimal = flyingAnimal;
            _flyingAnimal.Name = name;
        }

        public string GetName()
        {
            return _flyingAnimal.Name;
        }
    }
}
