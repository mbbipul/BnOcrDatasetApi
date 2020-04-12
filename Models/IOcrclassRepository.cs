using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace restApiDataset.Models
{
    public interface IOcrclassRepository
    {
        IQueryable<OcrClass> OcrClasses { get;}
        Task AddOcrClass(OcrClass ocrClass);
        Task<bool> UpdateOcrClass(OcrClass ocrClass);
        Task<ActionResult<OcrClass>> GetOcrClass(long id);
        Task<OcrClass> DeleteOcrClassR(int ocrClassId);
    }
}