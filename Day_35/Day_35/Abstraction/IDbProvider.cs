using Day_35.Controllers;
using System;
using System.Collections.Generic;

namespace Day_35.Abstraction
{
    public interface IDbProvider<T>
    {
        void Add(T item);
        List<T> GetAll();
        T GetElement(Func<T, bool> predicate);
        void UpdateElement(Func<T, bool> predicate, T newElement);
        void DeleteElement(Func<T, bool> predicate);

    }
}