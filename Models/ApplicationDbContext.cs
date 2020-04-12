using Microsoft.EntityFrameworkCore;

namespace restApiDataset.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
        public DbSet<OcrClass> OcrClasses { get; set;}
    }
}