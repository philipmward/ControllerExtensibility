using ControllerExtensibility.Models;
using System.Web.Mvc;
using System.Web.SessionState;

namespace ControllerExtensibility.Controllers
{
    //disables session state which improves performance at the loss of session state tracking. HttpContext.Session property will always return null.
    [SessionState(SessionStateBehavior.Disabled)]
    public class FastController : Controller
    {
        public ActionResult Index()
        {
            return View("Result", new Result { ControllerName = "Fast", ActionName = "Index" });
        }
    }
}