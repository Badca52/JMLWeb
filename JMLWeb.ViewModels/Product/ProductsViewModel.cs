using JMLWeb.Business.Product;
using System.Collections.Generic;

namespace JMLWeb.ViewModels
{
    public partial class ProductsViewModel
    {
        public List<Product> Products { get; set; }

        public ProductsViewModel()
        {
            Products = new List<Product>();
        }
    }
}
