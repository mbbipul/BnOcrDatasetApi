using System.Linq;

namespace restApiDataset.Models
{
    public class EFConsonantDiacretic : IConsonantDiacretic
    {
        OcrDbContext context;
        public EFConsonantDiacretic(OcrDbContext ctx){
            this.context = ctx;
        }
        public IQueryable<OcrClass> GetConsonantDiacretics(){
            return context.OcrClasses.Where( ol => (ol.ConsonantDiacreticId != "0"));

        }
        public IQueryable<OcrClass> GetConsonantDiacreticsById(string id){
            return context.OcrClasses.Where( ol => ol.ConsonantDiacreticId == id);
        }
    }
}