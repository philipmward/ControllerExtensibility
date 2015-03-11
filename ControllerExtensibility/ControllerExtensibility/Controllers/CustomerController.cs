using ControllerExtensibility.Models;
using System.Web.Mvc;

namespace ControllerExtensibility.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View("Result", new Result { ControllerName = "Customer", ActionName = "Index" });
        }

        //ActionName replaces the action name. So going to /Customer/List will no longer work, instead /Customer/Enumerate will work for this method.
        [ActionName("Enumerate")]
        public ActionResult List()
        {
            return View("Result", new Result { ControllerName = "Customer", ActionName = "List" });
        }

        //The NonAction attribute will disqualify an otherwise qualifying action method from being called. Generally you would just make the method private to
        //disqualify it, but if for some reason you must mark an inner-working method as public and you don't want it exposed you can use this tag.
        [NonAction]
        public ActionResult MyAction()
        {
            return View();
        }
    }
}