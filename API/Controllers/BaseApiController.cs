using API.Helpers;
using Microsoft.AspNetCore.Mvc;

// dotnet watch --no-hot-reload

namespace API.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    { 

    }
}