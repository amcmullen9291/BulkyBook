using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data;
public class ApplicationDbContext :DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) //keyword 'ctor'
    {
        
    }

    public DbSet<Category> Categories { get; set; } //the model and table name
}

//configuration syntax inside 'constructor' is saying: Recieved options will be passed to the base class, DBContext.
