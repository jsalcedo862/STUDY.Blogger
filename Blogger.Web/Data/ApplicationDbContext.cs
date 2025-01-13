using Blogger.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Blogger.Web.Data
{
    // this class will be a database context
    // database context is a class that will be used to interact with the database
    public class ApplicationDbContext : DbContext
    {
        // this is the name of the table in the database
        // create dbset of type Category (our class created for the db)
        public DbSet<Category> Category { get; set; }

        // we need to let this class know that the connection string is in app settings
        // do so in the program.cs file

        // retrieve options from program.cs
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

    }
}
