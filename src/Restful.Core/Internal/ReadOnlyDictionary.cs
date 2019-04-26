using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Restful.Core
{

    public static class ReadOnlyDictionary
    {
        public static IReadOnlyDictionary<TKey, TValue> Empty<TKey, TValue>()
        {
            return new EmptyReadOnlyDictionary<TKey, TValue>();
        }

        private class EmptyReadOnlyDictionary<TKey, TValue> : IReadOnlyDictionary<TKey, TValue>
        {
            public int Count => 0;

            public IEnumerable<TKey> Keys => Enumerable.Empty<TKey>();

            public IEnumerable<TValue> Values => Enumerable.Empty<TValue>();

            public TValue this[TKey key] => throw new KeyNotFoundException();

            public bool ContainsKey(TKey key) => false;

            public bool TryGetValue(TKey key, out TValue value)
            {
                value = default;
                return false;
            }

            public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
                => Enumerable.Empty<KeyValuePair<TKey, TValue>>().GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator()
                => ((IReadOnlyDictionary<TKey, TValue>)this).GetEnumerator();
        }
    }
}
