using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Restful.AspNetCore.Mvc
{
    public class HypermediaResult<TResource> : IActionResult
    {
        public HypermediaResult(IEnumerable<TResource> entities)
        {
            throw new NotImplementedException();
        }

        public HypermediaResult<TResource> Link<TResult>(string rel, Expression<Func<TResource, TResult>> linkAction)
        {
            throw new NotImplementedException();
        }

        public HypermediaResult<TResource> Link<TResult>(string rel, Expression<Func<TResource, Task<TResult>>> linkAction)
        {
            throw new NotImplementedException();
        }

        public HypermediaResult<TResource> Embed<TResult>(string rel, Func<TResult> embedAction)
        {
            throw new NotImplementedException();
        }

        public HypermediaResult<TResource> Embed<TResult>(string rel, Func<Task<TResult>> embedAction)
        {
            throw new NotImplementedException();
        }

        Task IActionResult.ExecuteResultAsync(ActionContext context)
        {
            throw new NotImplementedException();
        }
    }
}
