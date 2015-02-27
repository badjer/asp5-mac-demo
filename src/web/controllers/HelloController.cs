using Microsoft.AspNet.Mvc;
using Asp5MacDemo.Logic;

namespace Asp5MacDemo.Web.Controllers
{
    public class HelloController : Controller
    {
        public string World()
        {
          return Hello.World();
        }
    }
}
