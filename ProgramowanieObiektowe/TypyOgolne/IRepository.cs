namespace ProgramowanieObiektowe.TypyOgolne
{
    public interface IRepository<T> where T : class, new() // Wymuszenie konstruktora bez argumentowego
                                                           // struct - typy proste, nie referencyjne
    {

    }
}
