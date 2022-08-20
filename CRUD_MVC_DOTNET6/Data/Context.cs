using CRUD_MVC_DOTNET6.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_MVC_DOTNET6.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        { }

        public DbSet<Usuario> Usuario { get; set; }

    }
}