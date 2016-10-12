using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Wedding.Web.Models.Memory
{
    public class MemorySaveRequest
    {
        public string Name { get; set; }

        public string Comment { get; set; }

        public bool IsLanceSick { get; set; }
    }
}