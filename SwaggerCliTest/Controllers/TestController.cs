using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerCliTest.Controllers
{
    [Controller]
    [Route("api/test")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public List<int> Get() => new List<int> { 1, 2, 3 };
    }
}
