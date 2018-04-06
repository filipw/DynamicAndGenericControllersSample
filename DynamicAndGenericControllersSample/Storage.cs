using System;
using System.Collections.Generic;
using System.Linq;

namespace DynamicAndGenericControllersSample
{
    public class Storage<T> where T : class
    {
        private Dictionary<Guid, T> storage = new Dictionary<Guid, T>();

        public IEnumerable<T> GetAll() => storage.Values;

        public T GetById(Guid id)
        {
            return storage.FirstOrDefault(x => x.Key == id).Value;
        }

        public void Add(Guid id, T item)
        {
            storage[id] = item;
        }
    }
}
