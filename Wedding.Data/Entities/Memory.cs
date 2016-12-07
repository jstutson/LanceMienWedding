namespace Wedding.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Memory")]
    public partial class Memory
    {
        public int MemoryId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public string Comment { get; set; }

        public bool? IsLanceSick { get; set; }
    }
}
