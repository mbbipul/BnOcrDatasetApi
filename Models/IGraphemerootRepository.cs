using System.Linq;
using System.Threading.Tasks;

namespace restApiDataset.Models
{
    public interface IGraphemerootRepository
    {
        IQueryable<OcrClass> GetGraphemeroots ();
        IQueryable<OcrClass> GetGraphemeByrootId(string id);
    }
}