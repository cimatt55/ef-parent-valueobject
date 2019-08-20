using Microsoft.EntityFrameworkCore;

namespace NestedValueObject
{
    public class ParentContext : DbContext
    {
        public ParentContext(DbContextOptions<ParentContext> options) : base(options)
        {
        }

        public DbSet<Parent> Parents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Parent>().OwnsOne(p => p.PrimaryAddress);

            // Flatten the ValueObject fields into table
            modelBuilder.Entity<Parent>().OwnsOne(p => p.PrimaryAddress).
                Property(b => b.BuildingNumber).IsRequired().
                    HasColumnName("Primary_BuildingName");
        }
    }
}
