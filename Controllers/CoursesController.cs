using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Web.Mvc;
using egDotNetMVC.Models.Courses;
using egDotNetMVC.Models.Registration;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace egDotNetMVC.Controllers
{
    public class CoursesController : Controller
    {
        private CourseVmContext db = new CourseVmContext();

        //private RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();

        public ActionResult Index()
        {
            return View(db.CourseVms);
        }
    }
}
