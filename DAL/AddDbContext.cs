using BZLAND.Areas.Admin.ViewModel;
using BZLAND.Models;
using Microsoft.EntityFrameworkCore;

namespace BZLAND.DAL
{
    public class AddDbContext:DbContext
    {
        public AddDbContext(DbContextOptions<AddDbContext>options):base(options) 
        { 
        
        
        }
        public DbSet<Team> Teams { get; set; }

    }
}
