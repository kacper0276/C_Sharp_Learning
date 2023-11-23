namespace ProgramowanieObiektowe.Solid
{
    public abstract class Animal
    {
        public string Name { get; set; } = nameof(Animal);
        public abstract void Run();
    }

    

    
}
