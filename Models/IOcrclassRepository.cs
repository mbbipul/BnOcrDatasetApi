using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace restApiDataset.Models
{
    public interface IOcrclassRepository
    {
        IQueryable<OcrClass> OcrClasses { get;}
        Task AddOcrClass(OcrClass ocrClass);
        void AddOcrClasses(List<OcrClassWithImageData> ocrClass);
        Task<bool> UpdateOcrClass(OcrClass ocrClass);
        Task<ActionResult<OcrClass>> GetOcrClass(long id);
        Task<OcrClass> DeleteOcrClassR(int ocrClassId);
        Task DeleteAllOcrClass();
        IQueryable<OcrClass> GetClassesByFontName(string fontName);
        IQueryable<OcrClass> GetClassesByGraphemeIds(string graphemeRootId,string vDiaId,string cDiaId);
        IQueryable<OcrClass> GetClassesByGraphemeRVId(string graphemeRootId,string vDiaId);
        IQueryable<OcrClass> GetClassesByGraphemeRCId(string graphemeRootId,string cDiaId);
        IQueryable<OcrClass> GetClassesByGraphemeVCId(string vDiaId,string cDiaId);

        IQueryable<OcrClass> GetClassesGroupByFontName();
    }
}