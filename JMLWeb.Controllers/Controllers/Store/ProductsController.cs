using JMLWeb.Business.Product;
using JMLWeb.ViewModels;
using System.Web.Mvc;

namespace JMLWeb.Controllers.Controllers.Store
{
    public class ProductsController : Controller
    {
        public ActionResult Index()
        {
            ProductViewModel vw = new ProductViewModel();
            vw.Product = new Product("Jeff's Product", 3.95m);
            return View("Index", vw);
        }
    }
}
