using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Models
{
    internal class ListIterator<T> : IIterator<T>
    {
        private readonly List<T> _genericList;
        private int _index;

        public ListIterator(List<T> genericList)
        {
            _genericList = genericList;
        }

        public bool HasNext()
        {
            return (_index < _genericList.Count);
        }

        public T GetCurrent()
        {
            return _genericList.ElementAt(_index);
        }

        public void Next()
        {
            _index++;
        }
    }
}
