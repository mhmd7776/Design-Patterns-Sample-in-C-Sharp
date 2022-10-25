
namespace Iterator.Models
{
    public interface IIterator<out T>
    {
        bool HasNext();

        T GetCurrent();

        void Next();
    }
}
