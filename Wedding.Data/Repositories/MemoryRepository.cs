using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wedding.Data.Entities;

namespace Wedding.Data.Repositories
{
    public class MemoryRepository : IMemoryRepository
    {
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Memory> Get(int id)
        {
            
            throw new NotImplementedException();
        }

        public async Task Insert(Memory memory)
        {
            using(var context = new LanceWeddingEntities())
            {
                context.Memories.Add(memory);
                await context.SaveChangesAsync();
            }
        }

        public Task Update(Memory memory)
        {
            throw new NotImplementedException();
        }
    }
}
