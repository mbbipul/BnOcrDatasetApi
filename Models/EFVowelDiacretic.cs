using System.Linq;

namespace restApiDataset.Models
{
    public class EFVowelDiacretic : IVowelDiacretic
    {
        private ApplicationDbContext context;
        public EFVowelDiacretic(ApplicationDbContext ctx){
            this.context = ctx;
        }
        public IQueryable<OcrClass> GetVowelDiacretics(){
            return context.OcrClasses.Where( oc => oc.VowelDiacreticId != "0");
        }
        public IQueryable<OcrClass> GetVowelDiacreticsById(string id){
            return context.OcrClasses.Where( oc => oc.VowelDiacreticId == id);
        }
    }
}