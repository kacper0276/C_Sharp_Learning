namespace ProgramowanieObiektowe.KlasaAbstrakcyjnaVS_Interfejs
{
    public interface IProductService
    {
        void Update(Product product);
        static abstract string GetProductName();

        // Domyślna implementacja
        int Add(Product product)
        {
            return 0;
        }
    }
}
