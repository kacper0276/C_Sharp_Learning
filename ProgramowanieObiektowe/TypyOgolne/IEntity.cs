namespace ProgramowanieObiektowe.TypyOgolne
{
    public interface IEntity<TPrimaryKey>
        where TPrimaryKey : struct
    {
        public TPrimaryKey Id { get; set; }
    }
}
