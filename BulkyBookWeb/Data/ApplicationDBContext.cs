using Microsoft.EntityFrameworkCore;
using BulkyBookWeb.Models;
namespace BulkyBookWeb.Data;
public class ApplicationDBContext :DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) //keyword 'ctor'
    {
        
    }

    public DbSet<Category>  //the model slash table name
}

//configuration syntax inside 'constructor' is saying: Recieved options will be passed to the base class, DBContext.
