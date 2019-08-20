using Microsoft.EntityFrameworkCore;

namespace NestedValueObject
{
    public class ChildContext : DbContext
    {
        public ChildContext(DbContextOptions<ChildContext> options) : base(options)
        {
        }

        public DbSet<Child> Children { get; set; }
    }
}
