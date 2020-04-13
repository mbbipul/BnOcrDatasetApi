using System.Linq;

namespace restApiDataset.Models
{
    public interface IConsonantDiacretic
    {
        IQueryable<OcrClass> GetConsonantDiacretics();
        IQueryable<OcrClass> GetConsonantDiacreticsById(string id);
    }
}