using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace Restful.AspNetCore.Mvc.Formatters
{
    public class HalXmlOutputFormatter : TextOutputFormatter
    {
        public HalXmlOutputFormatter()
        {
            SupportedEncodings.Add(Encoding.UTF8);
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("application/xml"));
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("application/hal+xml"));
        }

        public override Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
        {
            throw new NotImplementedException();
        }
    }
}
