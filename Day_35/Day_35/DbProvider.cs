using Day_35.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_35
{
    public class DbProvider<T> : IDbProvider<T>
    {
        private List<T> _dbObjects = new List<T>();

        public void Add(T item)
        {
            _dbObjects.Add(item);
        }

        public List<T> GetAll()
        {
            List<T> items = new List<T>();
            foreach (var item in _dbObjects)
            {
                items.Add(item);
            }
            return items;
        }

        public T GetElement(Func<T, bool> predicate)
        {
            return _dbObjects.Where(el => predicate(el)).First();
        }

        public void UpdateElement(Func<T, bool> predicate, T newElement)
        {
            var element = GetElement(el => predicate(el));
            _dbObjects[_dbObjects.IndexOf(element)] = newElement; 
            // აქ id იცვლება, რაც რა თქმა უნდა მიუღებელია, თუმცა ვერ მივხვდი სხვანაირად როგორ უნდა გამეკეთებინა
        }

        public void DeleteElement(Func<T, bool> predicate)
        {
            _dbObjects.Remove(GetElement(el => predicate(el)));
        }

    }
}