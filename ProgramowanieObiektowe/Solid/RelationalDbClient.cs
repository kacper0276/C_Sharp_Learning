namespace ProgramowanieObiektowe.Solid
{
    public class RelationalDbClient
    {
        public T? Query<T>(string query)
        {
            Console.WriteLine(query);
            return default; // int defaultValue = default(int); // defaultValue będzie równa 
        }
    }
}