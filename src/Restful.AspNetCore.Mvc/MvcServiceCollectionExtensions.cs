using System;
using Microsoft.Extensions.DependencyInjection;
using Restful.Core;

namespace Restful.AspNetCore.Mvc
{
    public static class MvcServiceCollectionExtensions
    {
        public static IHalBuilder AddHal(this IServiceCollection services)
            => AddHal(services, opts => { });

        public static IHalBuilder AddHal(this IServiceCollection services, Action<HalOptions> optionsAction)
        {
            var options = new HalOptions();
            optionsAction.Invoke(options);

            throw new NotImplementedException();
        }
    }
}
