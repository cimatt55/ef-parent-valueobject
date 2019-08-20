using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace NestedValueObject
{
    
    public class ParentContextFactory : IDesignTimeDbContextFactory<ParentContext>
    {
        public ParentContext CreateDbContext(string[] args)
        {
            var parentContextOptionsBuilder = new DbContextOptionsBuilder<ParentContext>();

            parentContextOptionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=NestedValueObject;Trusted_Connection=true;");

            return new ParentContext(parentContextOptionsBuilder.Options);
        }
    }
}
