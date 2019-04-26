namespace Restful.Core
{


    public interface ILink
    {
        string Name { get; }

        string Href { get; }

        string Type { get; }
    }

    public class TemplatedLink : ILink
    {
        public string Name { get; }

        public string Href { get; }

        public string Type { get; }
    }

    public class Link : ILink
    {
        public string Name { get; }

        public string Href { get; }

        public string Type { get; }
    }
}
