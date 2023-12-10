namespace OperacjeNaDanych.PlikiJSON
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = nameof(Product);
        public decimal Cost { get; set; } = 0;
        public bool IsSold { get; set; }
    }
}
