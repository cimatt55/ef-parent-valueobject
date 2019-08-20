using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace NestedValueObject
{
    public class ChildContextFactory : IDesignTimeDbContextFactory<ChildContext>
    {
        public ChildContext CreateDbContext(string[] args)
        {
            var childContextOptionsBuilder = new DbContextOptionsBuilder<ChildContext>();

            childContextOptionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=NestedValueObject;Trusted_Connection=true;");

            return new ChildContext(childContextOptionsBuilder.Options);
        }
    }
}
