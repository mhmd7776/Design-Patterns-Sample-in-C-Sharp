
namespace Iterator.Models
{
    public class BrowserHistory
    {
        private readonly List<string> _urls = new();

        public void Push(string url)
        {
            _urls.Add(url);
        }

        public IIterator<string> CreateIterator()
        {
            return new ListIterator<string>(_urls);
        }
    }
}
