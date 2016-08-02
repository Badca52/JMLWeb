using JMLWeb.DataAccess;
using JMLWeb.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace JMLWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ProductsViewModel vw = new ProductsViewModel();

            using (DataContext db = new DataContext())
            {
                vw.Products = db.Products.ToList();
            }

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