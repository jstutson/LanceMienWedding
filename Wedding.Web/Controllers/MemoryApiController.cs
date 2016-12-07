using System.Collections.Generic;
using System.Web.Http;
using Wedding.Web.Models.Memory;
using Wedding.Data.Repositories;
using Wedding.Data.Entities;
using System.Threading.Tasks;

namespace Wedding.Web.Controllers
{
    [RoutePrefix("memory")]   // {domain}/memory/save
    public class MemoryApiController : ApiController
    {
        private IMemoryRepository memoryRepository;

        public MemoryApiController()
        {
            memoryRepository = new MemoryRepository();
        }

        [Route("save")]
        [HttpPost]
        public async Task<IHttpActionResult> SaveMemory(MemorySaveRequest request)
        {
            var memoryEntity = new Memory
            {
                Comment = request.Comment,
                IsLanceSick = request.IsLanceSick,
                Name = request.Name
            };
            
            await memoryRepository.Insert(memoryEntity);
            
            return Ok();
        }
    }
}
