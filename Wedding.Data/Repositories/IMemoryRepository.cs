using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding.Data.Repositories
{
    public interface IMemoryRepository
    {
        object Get(int id);

        void Insert(object memory);

        void Update(object memory);

        void Delete(int id);
    }
}
