namespace Wedding.Data.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LanceWeddingEntities : DbContext
    {
        public LanceWeddingEntities()
            : base("name=LanceWedding")
        {
        }

        public virtual DbSet<Memory> Memories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
