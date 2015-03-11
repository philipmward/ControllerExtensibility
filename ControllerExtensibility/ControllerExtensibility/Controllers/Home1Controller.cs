using ControllerExtensibility.Infrastructure;
using ControllerExtensibility.Models;
using System.Web.Mvc;

namespace ControllerExtensibility.Controllers
{
    public class Home1Controller : Controller
    {
        // GET: Home1
        public ActionResult Index()
        {
            return View("Result", new Result { ControllerName = "Home", ActionName = "Index" });
        }

        //Local comes from the custom LocalAttribute which narrows down the choice of which method is called.
        [Local]
        [ActionName("Index")]
        public ActionResult LocalIndex()
        {
            return View("Result", new Result { ControllerName = "Home", ActionName = "LocalIndex" });
        }

        //Default behavior for a HandleUnknownAction exeption is to throw a 404. You can change the default behavior with this override.
        protected override void HandleUnknownAction(string actionName)
        {
            Response.Write(string.Format("You requested the {0} action", actionName));
        }
    }
}