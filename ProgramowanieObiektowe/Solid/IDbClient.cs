namespace ProgramowanieObiektowe.Solid
{
    public interface IDbClient
    {
        T? Query<T>(string query);
    }
}
