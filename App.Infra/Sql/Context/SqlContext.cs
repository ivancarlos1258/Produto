using App.Core.Model.Sql;

using Microsoft.EntityFrameworkCore;


namespace App.Infra.SQL.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }
        public virtual DbSet<Produto> Produto { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasKey(c => new { c.ProductID});

          

            base.OnModelCreating(modelBuilder);
        }

    }
}
