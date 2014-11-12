using System.Web.Mvc;
using egDotNetMVC.Models.Registration;

namespace egDotNetMVC.Controllers
{
    public class InstructorsController : Controller
    {
        private RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();
        
        public ActionResult Index()
        {
            return View("Index", "", _registrationVmBuilder.GetSerializedInstructors());
        }

    }
}
