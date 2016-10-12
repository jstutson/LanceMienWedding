using System.Collections.Generic;
using System.Web.Http;
using Wedding.Web.Models.Memory;

namespace Wedding.Web.Controllers
{
    [RoutePrefix("memory")]   // {domain}/memory/save
    public class MemoryApiController : ApiController
    {
        [Route("save")]
        [HttpPost]
        public IHttpActionResult SaveMemory(MemorySaveRequest request)
        {
            // TODO: upload the image to our blob server
            // TODO: update model with the URL for the image blob that we get back from saving to the blob server.
            // If image save fails, return an error response
            // else if successful then save the memory to our DB via entity framework
            // along with the URL to our image.
            
            return Ok();
        }
    }
}
