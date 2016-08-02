using JMLWeb.Business.Product;
using JMLWeb.ViewModels;
using System.Web.Mvc;

namespace JMLWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Product p = new Product("Jeff's Product", 3.95m);
            ProductViewModel vw = new ProductViewModel();
            vw.Product = p;
            return View("Index", vw);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}