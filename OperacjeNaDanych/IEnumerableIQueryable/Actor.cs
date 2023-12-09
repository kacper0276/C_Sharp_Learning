namespace OperacjeNaDanych.IEnumerableIQueryable
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; } = $"Name{Guid.NewGuid():N}";
    }
}
