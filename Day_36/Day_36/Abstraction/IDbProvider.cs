using Day_36.Controllers;
using System;
using System.Collections.Generic;

namespace Day_36.Abstraction
{
    public interface IDbProvider<T>
    {
        void Add(T item);
        List<T> GetAll();
        T GetElement(int id);
        void UpdateElement(int id, T newElement);
        void DeleteElement(int id);

    }
}