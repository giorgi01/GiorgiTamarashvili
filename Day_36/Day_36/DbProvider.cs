using Day_36.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_36
{
    public class DbProvider<T> : IDbProvider<T> where T : Model
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

        public T GetElement(int id)
        {
            return _dbObjects.Where(el => el.Id == id).First();
        }

        public void UpdateElement(int id, T newElement)
        {
            var element = GetElement(id);
            newElement.Id = id;
            _dbObjects[_dbObjects.IndexOf(element)] = newElement;
        }

        public void DeleteElement(int id)
        {
            _dbObjects.Remove(GetElement(id));
        }

    }
}