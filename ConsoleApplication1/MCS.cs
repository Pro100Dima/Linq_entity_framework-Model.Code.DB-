namespace ConsoleApplication1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MCS : DbContext
    {
        public MCS()
            : base("name=MCS")
        {
        }

        public virtual DbSet<AccessTab> AccessTab { get; set; }
        public virtual DbSet<AccessUser> AccessUser { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
