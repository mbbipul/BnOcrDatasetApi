using Microsoft.EntityFrameworkCore;

namespace restApiDataset.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){
            this.Database.SetCommandTimeout(180);
        }
        public DbSet<OcrClass> OcrClasses { get; set;}
    }
}