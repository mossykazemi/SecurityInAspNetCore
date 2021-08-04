using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;

namespace SecurityInAspNet.WebApi.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("RouxAcademy")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new List<string>()
            {
                "ASP.Net Core",
                "Asp.net Mvc",
                "C#",
                "Security"
            };
        }
    }
}
