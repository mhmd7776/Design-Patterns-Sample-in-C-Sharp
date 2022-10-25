using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Models
{
    internal class ArrayIterator<T> : IIterator<T>
    {
        private readonly T[] _genericArray;
        private int _index;

        public ArrayIterator(T[] genericArray)
        {
            _genericArray = genericArray;
        }

        public bool HasNext()
        {
            return (_index < _genericArray.Count());
        }

        public T GetCurrent()
        {
            return _genericArray.ElementAt(_index);
        }

        public void Next()
        {
            _index++;
        }
    }
}
