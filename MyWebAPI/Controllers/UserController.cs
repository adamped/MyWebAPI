using Microsoft.AspNetCore.Mvc;

namespace MyWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            // Insert into database here
        }

    }
}
