namespace SnackMachine
{

    public abstract class ProductDecorator : Product
    {
        protected Product product;
        
        public ProductDecorator(string name, double price, Product product) : base(name, price)
        {
            this.product = product;
        }
    }
}
