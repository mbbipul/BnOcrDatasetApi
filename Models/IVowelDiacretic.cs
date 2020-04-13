using System.Linq;

namespace restApiDataset.Models
{
    public interface IVowelDiacretic
    {
        IQueryable<OcrClass> GetVowelDiacretics ();
        IQueryable<OcrClass> GetVowelDiacreticsById(string id);
    }
}