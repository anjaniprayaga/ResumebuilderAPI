using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Net;

namespace ResumebuilderAPI.Controllers
{
    [Route("[controller]")]
    //[Route("api/Resume")]
    public class ResumeController : ControllerBase
    {
        [HttpPost]
        public HttpResponseMessage CreateResume([FromBody] JObject payload)
        {
            
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpGet]
        public HttpResponseMessage GetResume()
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }


    }
}
