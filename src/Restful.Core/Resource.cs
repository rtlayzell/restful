using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Restful.Core
{
    public class Resource
    {
        public object State { get; }

        [JsonProperty("_links")]
        public LinkCollection Links { get; }

        [JsonProperty("_embedded")]
        public EmbeddedCollection Embedded { get; }


        public Resource()
            : this(Enumerable.Empty<Link>())
        {
        }

        public Resource(object state)
            : this(state, Enumerable.Empty<Link>())
        {
        }

        public Resource(IEnumerable<Link> links)
            : this(links, ReadOnlyDictionary.Empty<string, Resource>())
        {

        }

        public Resource(object state, IEnumerable<Link> links)
            : this(state, links, ReadOnlyDictionary.Empty<string, Resource>())
        {
        }

        public Resource(IEnumerable<Link> links, IReadOnlyDictionary<string, Resource> embedded)
        {
            Links = links?.ToLinkCollection() ?? throw new ArgumentNullException(nameof(links));
            Embedded = embedded?.ToEmbeddedCollection() ?? throw new ArgumentNullException(nameof(embedded));
        }

        public Resource(object state, IEnumerable<Link> links, IReadOnlyDictionary<string, Resource> embedded)
            : this(links, embedded)
        {
            State = state ?? throw new ArgumentNullException(nameof(state));
        }
    }
}
