using System;
using System.Collections;
using System.Collections.Generic;

namespace Utilities
{
    public class MyList<T> : IList<T>
    {
        private T[] _tArray;
        public MyList()
        {
            _tArray = new T[8];
        }
        public T this[int index]
        {
            get
            {
                return _tArray[index];
            }
            set
            {
                _tArray[index] = value;
            }
        }
        public int Count { get; private set; }
        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }
        public void Add(T item)
        {
            if (Count < _tArray.Length)
            {
                _tArray[Count] = item;
                Count++;
            }
        }
        public void Clear()
        {
            Count = 0;
        }
        public bool Contains(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_tArray[i].Equals(item))
                {
                    return true;
                }
            }
            return false;

        }
        public void CopyTo(T[] array, int arrayIndex)
        {
            int minLength = _tArray.Length + arrayIndex;
            if (minLength <= array.Length)
            {
                _tArray.CopyTo(array, arrayIndex);
            }
           
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)this._tArray).GetEnumerator();
        }

        public int IndexOf(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (_tArray[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Insert(int index, T item)
        {
            if ((Count + 1 <= _tArray.Length) && (index <= Count) && (index >= 0))
            {
                Count++;

                for (int i = Count - 1; i > index; i--)
                {
                    _tArray[i] = _tArray[i - 1];
                }
                _tArray[index] = item;
            }
        }
        public bool Remove(T item)
        {
            int p = IndexOf(item);
            if (p != -1)
            {
                RemoveAt(p);
                return true;
            }
            return false;
        }
        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < Count))
            {
                for (int i = index; i <= Count - 1; i++)
                {
                    if(i== _tArray.Length-1)
                    {
                        _tArray[i]=default(T);
                    }
                    else
                    {
                        _tArray[i] = _tArray[i + 1];
                    }
                    
                }
                Count--;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _tArray.GetEnumerator();
        }
        public void PrintContents()
        {
            Console.WriteLine($"List has a capacity of {_tArray.Length} and currently has {Count} elements.");
            Console.Write("List contents:");
            for (int i = 0; i < Count; i++)
            {
                Console.Write($" {_tArray[i]}");
            }
            Console.WriteLine();
        }
    }
}
