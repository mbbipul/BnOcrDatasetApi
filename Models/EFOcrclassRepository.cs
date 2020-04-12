using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace restApiDataset.Models
{
    public class EFOcrclassRepository : IOcrclassRepository
    {
        private ApplicationDbContext context;   
        public EFOcrclassRepository(ApplicationDbContext ctx){
            this.context = ctx;
        }
        public IQueryable<OcrClass> OcrClasses => context.OcrClasses;
        public async Task<ActionResult<OcrClass>> GetOcrClass(long id){
            var ocrClass = await context.OcrClasses.FindAsync(id);
            return ocrClass;
        }

        public async Task AddOcrClass(OcrClass ocrClass){
            context.OcrClasses.Add(ocrClass);
            await context.SaveChangesAsync();
        }
        public async Task AddOcrClasses(List<OcrClass> ocrClass){
            context.OcrClasses.AddRange(ocrClass);
            await context.SaveChangesAsync();
        }
        public async Task<bool> UpdateOcrClass(OcrClass ocrClass){
            OcrClass dbEntry = context.OcrClasses.
                FirstOrDefault(c => c.Id == ocrClass.Id);
            if(dbEntry != null){
                dbEntry.FileName = ocrClass.FileName;
                dbEntry.ImageData = ocrClass.ImageData;
                dbEntry.GraphemeRootId = ocrClass.GraphemeRootId;
                dbEntry.VowelDiacreticId = ocrClass.VowelDiacreticId;
                dbEntry.ConsonantDiacreticId = ocrClass.ConsonantDiacreticId;
                await context.SaveChangesAsync();
                return true;
            }
             return false;
        }

        public async Task<OcrClass> DeleteOcrClassR(int ocrClassId){
            OcrClass dbEntry = context.OcrClasses.
                    FirstOrDefault(c => c.Id == ocrClassId);
            if(dbEntry != null){
                context.OcrClasses.Remove(dbEntry);
                await context.SaveChangesAsync();
                return dbEntry;
            }
            return null;
        }
    }
}