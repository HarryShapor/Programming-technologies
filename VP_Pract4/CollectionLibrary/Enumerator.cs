using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionLibrary
{
    public class Enumerator<T> : IEnumerator<T>
    {
        private DynamicArray<T> array;
        private int _current = -1;

        public T Current
        {
            get
            {
                if (_current < 0 || _current >= array.Count)
                {
                    throw new Exception("Неверное значение!");
                }
                return array[_current];
            }
        }
        object IEnumerator.Current => Current;
        public Enumerator(DynamicArray<T> array)
        {
            this.array = array;
        }

        public bool MoveNext()
        {
            _current++;
            return _current < array.Count;
        }

        public void Reset()
        {
            _current = -1;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
