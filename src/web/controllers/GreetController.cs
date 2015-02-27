using Microsoft.AspNet.Mvc;

namespace Asp5MacDemo.Web.Controllers
{ 
  // Using [Route], we explicitly specify the routes
  // for this controller. These will get added to
  // the routes automatically
  [Route("greet")]
  public class GreetController : Controller 
  { 
    // With no [HttpGet], etc, it'll use the controller-level
    // route and assume the method names match the HTTP verbs
    // (ie, Web Api behavior)
    // Therefore, you can reach this at GET /greet?name=foo
    public string Get(string name) 
    { 
      return "Hello " + name; 
    } 

    // Define this route as /greet/french?name=foo
    // Since we use [HttpGet], we don't need the name
    // of the action to match a HTTP verb
    [HttpGet("french")]
    public string InFrench(string name)
    {
      return "Bonjour " + name;
    }
  }
}
