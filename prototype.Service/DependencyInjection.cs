using System;
using Microsoft.Extensions.DependencyInjection;

namespace prototype.Service
{
	public static class DependencyInjection
	{
        public static IServiceCollection AddApplication(this
        IServiceCollection services)
        {
            //services.AddMediatR(conf =>
            //conf.RegisterServicesFromAssembly(typeof(DependencyInjection)
            //.Assembly));
            ////services.AddTransient<IRequestHandler<GetAllTeamsQuery, IEnumerable<Team>>, GetAllTeamsQueryHandler>();
            return services;
        }
    }
}

