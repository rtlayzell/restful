using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Restful.Core
{
    public static class ReadOnlyList
    {
        public static IReadOnlyList<T> Empty<T>()
        {
            return new EmptyReadOnlyList<T>();
        }

        private sealed class EmptyReadOnlyList<T> : IReadOnlyList<T>
        {
            public int Count => 0;

            public T this[int index] => throw new ArgumentOutOfRangeException(nameof(index));


            public IEnumerator<T> GetEnumerator() => Enumerable.Empty<T>().GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator() => ((IReadOnlyList<T>)this).GetEnumerator();
        }
    }
}
