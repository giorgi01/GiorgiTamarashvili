using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Midterm_3
{
    public class MyList<T> : IEnumerable
    {
        private T[] _arr;

        public MyList()
        {
            _arr = new T[0];
        }

        public void Add(T element)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = element;
        }

        public void AddRange(params T[] elements)
        {
            Array.Resize(ref _arr, _arr.Length + elements.Length);
            for (int i = _arr.Length - elements.Length, j = 0; i < _arr.Length; i++, j++)
            {
                _arr[i] = elements[j];
            }
        }

        public bool Remove(T element)
        {
            bool found = false;
            var new_arr = new T[_arr.Length-1];
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i].Equals(element))
                {
                    Array.Copy(_arr, 0, new_arr, 0, i+1);
                    Array.Copy(_arr, i+1, new_arr, i, new_arr.Length-i);
                    found = true;
                    break;
                }
            }
            _arr = new_arr;
            return found;
        }

        public void RemoveRange(int index, int count)
        {
            var new_arr = new T[_arr.Length - count];
            Array.Copy(_arr, 0, new_arr, 0, index);
            Array.Copy(_arr, index+count, new_arr, index, _arr.Length-count);
            _arr = new_arr;
        }

        public void RemoveAt(int index)
        {
            var new_arr = new T[_arr.Length - 1];
            Array.Copy(_arr, 0, new_arr, 0, index+1);
            Array.Copy(_arr, index+1, new_arr, index, _arr.Length-1);
            _arr = new_arr;
        }

        public int Indexer(T element)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if(_arr[i].Equals( element))
                {
                    return i;
                }
            }
            return -1;
        }

        public int Count()
        {
            return _arr.Length;
        }

        public bool Contains(T element)
        {
            bool contains = false;
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i].Equals(element))
                {
                    contains = true;
                }
            }
            return contains;
        }

        public MyList<T> Where(Func<T, bool> predicate)
        {
            var myList = new MyList<T>();
            for (int i = 0; i < _arr.Length; i++)
            {
                if (predicate(_arr[i]))
                {
                    myList.Add(_arr[i]);
                }
            }
            return myList;
        }

        public T Single(Func<T, bool> predicate)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (predicate(_arr[i]))
                {
                    return _arr[i];
                }
            }
            throw new SingleDidNotFoundAnElementException();
        }

        public T SingleOrDefault(Func<T, bool> predicate)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (predicate(_arr[i]))
                {
                    return _arr[i];
                }
            }
            return default;
        }

        public T Find(Predicate<T> predicate)
        {
            foreach (T item in this)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
            return default;
        }

        public IEnumerator GetEnumerator()
        {
            return _arr.GetEnumerator();
        }
    }
}
