namespace Restful.Core
{
    public class HalOptions
    {
        public bool AutoSelfLink { get; set; } = true;

        public LinkFormatting LinkFormatting { get; set; } = LinkFormatting.Object;
    }
}
