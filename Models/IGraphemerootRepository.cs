using System.Linq;
using System.Threading.Tasks;

namespace restApiDataset.Models
{
    public interface IGraphemerootRepository
    {
        IQueryable<OcrClass> GetGraphemeroots ();
        IQueryable<OcrClass> GetGraphemeByrootId(string id);
        IQueryable<OcrClass> GetGraphemeByrootIdByName(string id,string fontName);
        IQueryable<OcrClass> GetGraphemeByrootIdOrderByFont(IQueryable<OcrClass> ocrClasses);
    }
}