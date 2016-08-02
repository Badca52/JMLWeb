namespace JMLWeb.Business.Product
{
    public partial class Product : BaseProduct
    {
        public Product()
            : base()
        {

        }

        public Product(string name, decimal price)
            : base(name, price)
        {

        }
    }

    public partial class BaseProduct : OntologyIdentity, IBaseProduct
    {
        #region Properties
        public virtual string Name { get; set; }

        public virtual decimal Price { get; set; }
        #endregion


        #region Constructors
        public BaseProduct()
            : base()
        {
        }

        public BaseProduct(string name, decimal price)
            : base()
        {
            Name = name;
            Price = price;
        }
        #endregion


    }
}
