using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.Mvc.Routing;

namespace Restful.AspNetCore.Mvc.Formatters
{
    public class HalJsonOutputFormatter : TextOutputFormatter
    {
        public HalJsonOutputFormatter()
        {
            SupportedEncodings.Add(Encoding.UTF8);
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("application/json"));
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("application/hal+json"));
        }

        public override Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
        {
            throw new NotImplementedException();
        }
    }
}
