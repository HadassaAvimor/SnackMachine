namespace SnackMachine.Suppliers;

internal class CocaColaSupplier : Supplier
{
    public CocaColaSupplier(string name, string email, Dictionary<Product, List<Product>> products) : base(name, email, products)
    {
    }


}

