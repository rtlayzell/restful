using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Restful.AspNetCore.Mvc.UnitTests
{
    [Route("restful-unit-tests")]
    public class RestControllerTests : RestController
    {
        [HttpGet]
        public async Task<IActionResult> GetResourcesAsync(int offset, int limit)
        {
            var resources = new[] 
            {
                new { Id = 1 },
                new { Id = 2 },
                new { Id = 3 },
            };

            var min = 0;
            var max = resources.Length - 1;

            return SingletonResource(new { Count = limit, Total = resources.Length })
                .Link("find", r => GetResourceByIdAsync(Exp.Var<int>()))
                .Link("next", r => GetResourcesAsync(Math.Min(offset + limit, max), limit)) //, c => c.Condition(r => offset < max))
                .Link("prev", r => GetResourcesAsync(Math.Max(offset - limit, min), limit)) //, c => c.Condition(r => offset > min))
                .Embed("students", () => CollectionResource(resources)
                    .Link("self", r => GetResourceByIdAsync(r.Id))
                    .Link("singleton", r => GetResourceSingletonAsync(r.Id))
                    .Link("collection", r => GetResourceCollectionAsync(r.Id)));
        }

        [HttpGet("{id}")]
        public Task<IActionResult> GetResourceByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        
        [HttpGet("{id}/singleton")]
        public Task<IActionResult> GetResourceSingletonAsync(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}/collection")]
        public Task<IActionResult> GetResourceCollectionAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
