using System;
using System.Collections;
using System.Collections.Generic;

namespace Restful.Core
{
    public class LinkCollection : IList<Link>
    {
        private readonly Dictionary<string, Link> _collection;

        public Link this[string rel]
        {
            get => _collection[rel];
            set => _collection[rel] = value;
        }
        public Link this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IEnumerable<string> Relations { get => _collection.Keys; }
        public int Count { get; }
        public bool IsReadOnly { get; }

        public void Add(Link item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Link item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Link[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Link> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(Link item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, Link item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Link item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
