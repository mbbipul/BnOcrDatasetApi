namespace restApiDataset.Models
{
    public class OcrClass {
        public long Id { get; set;}
        public string FileName { get;set;}
        public int FontSize { get;set;}
        public string ImageData { get; set;}
        public string GraphemeRootId { get; set;}
        public string VowelDiacreticId {get; set; }
        public string ConsonantDiacreticId { get; set;}
    }
}