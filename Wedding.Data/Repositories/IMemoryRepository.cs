using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wedding.Data.Entities;

namespace Wedding.Data.Repositories
{
    public interface IMemoryRepository
    {
        Task<Memory> Get(int id);

        Task Insert(Memory memory);

        Task Update(Memory memory);

        Task Delete(int id);
    }
}
