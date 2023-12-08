namespace ProgramowanieObiektoweCzęśćII.WłasneAtrybuty
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Module)] // Co chcemy Cacheowac,
    // Cacheowac mozemy tylko klasy i moduly
    internal class Cacheable : Attribute
    {
    }
}
