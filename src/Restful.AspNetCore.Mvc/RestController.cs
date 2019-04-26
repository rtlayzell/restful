using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restful.AspNetCore.Mvc
{
    public abstract class RestController : ControllerBase
    {
        protected HypermediaResult<object> SingletonResource()
        {
            throw new NotImplementedException();
        }

        protected HypermediaResult<TResource> SingletonResource<TResource>(TResource resource)
        {
            throw new NotImplementedException(); 
        }

        protected HypermediaResult<TResource> CollectionResource<TResource>(IEnumerable<TResource> resource)
        {
            throw new NotImplementedException();
        }

        protected TController Controller<TController>()
        {
            throw new NotImplementedException();
        }
    }
}
