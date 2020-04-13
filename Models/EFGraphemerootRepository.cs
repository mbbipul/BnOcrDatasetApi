using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace restApiDataset.Models
{
    public class EFGraphemerootRepository : IGraphemerootRepository
    {
        private ApplicationDbContext context;   
        public EFGraphemerootRepository(ApplicationDbContext ctx){
            this.context = ctx;
        }
        public IQueryable<OcrClass> GetGraphemeroots(){
            return context.OcrClasses.Where( cl => (cl.VowelDiacreticId == "0") && (cl.ConsonantDiacreticId == "0"));
        }
        public IQueryable<OcrClass> GetGraphemeByrootId(string id)
        {
            return context.OcrClasses.Where( cl => cl.GraphemeRootId == id);
        }
    }
}