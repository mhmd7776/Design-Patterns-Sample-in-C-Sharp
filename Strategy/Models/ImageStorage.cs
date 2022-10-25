namespace Strategy.Models
{
    public class ImageStorage
    {
        private readonly ICompressor _compressor;
        private readonly IFilter _filter;

        public ImageStorage(ICompressor compressor, IFilter filter)
        {
            _compressor = compressor;
            _filter = filter;
        }

        public void StoreImage(string fileName)
        {
            _compressor.Compress(fileName);
            _filter.Filter(fileName);
        }
    }
}
