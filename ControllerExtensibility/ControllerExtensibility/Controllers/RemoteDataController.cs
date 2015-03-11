using ControllerExtensibility.Models;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ControllerExtensibility.Controllers
{
    public class RemoteDataController : Controller
    {
        public async Task<ActionResult> ConsumeAsyncMethod()
        {
            var data = await new RemoteService().GetRemoteDataAsync();

            return View("Data", (object)data);
        }

        public async Task<ActionResult> Data()
        {
            var data = await Task<string>.Factory.StartNew(() => new RemoteService().GetRemoteData());

            return View((object)data);
        }

        //public ActionResult Data()
        //{
        //    var service = new RemoteService();
        //    var data = service.GetRemoteData();

        //    return View((object)data);
        //}
    }
}