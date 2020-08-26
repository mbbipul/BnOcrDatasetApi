using BnOcrDatasetApi.Models;
using Microsoft.EntityFrameworkCore;

namespace restApiDataset.Models
{
    public class OcrDbContext : DbContext
    {
        public OcrDbContext(){}
        public OcrDbContext(DbContextOptions<OcrDbContext> options) : base(options){
            Database.SetCommandTimeout(150000);

        }
        public DbSet<OcrClass> OcrClasses { get; set;}
        public DbSet<OcrTrash> OcrTrashes { get; set;}

    }
}