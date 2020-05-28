using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Architecture.Database
{
    public sealed class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Context>();

            builder.UseSqlServer("Server=185.55.224.148;Database=basimdat_Basim;User ID=basimdat_sa;Password=ha#jaBD@14;");

            return new Context(builder.Options);
        }
    }
}
