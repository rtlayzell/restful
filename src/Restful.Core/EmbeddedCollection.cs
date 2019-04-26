using System;
using System.Collections;
using System.Collections.Generic;

namespace Restful.Core
{
    public class EmbeddedCollection : IList<Resource>, IReadOnlyDictionary<string, Resource>
    {
        public Resource this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Resource this[string key] { get => throw new NotImplementedException(); }

        public IEnumerable<string> Keys { get; }
        public IEnumerable<Resource> Values { get; }
        public int Count { get; }
        public bool IsReadOnly { get; }

        public void Add(Resource item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Resource item)
        {
            throw new NotImplementedException();
        }

        public bool ContainsKey(string key)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Resource[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<string, Resource>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(Resource item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, Resource item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Resource item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(string key, out Resource value)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<Resource> IEnumerable<Resource>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public static class EnumerableExtensions
    {
        public static LinkCollection ToLinkCollection(this IEnumerable<Link> collection)
        {
            var links = new LinkCollection();
            foreach (var link in collection)
                links.Add(link);
            return links;
        }

        public static EmbeddedCollection ToEmbeddedCollection(this IEnumerable<KeyValuePair<string, Resource>> collection)
        {
            throw new NotImplementedException();
            //var embedded = new EmbeddedCollection();
            //foreach (var resource in collection)
            //    embedded.Add(resource.Key, resource.Value);

            //return embedded;
        }
    }
}
