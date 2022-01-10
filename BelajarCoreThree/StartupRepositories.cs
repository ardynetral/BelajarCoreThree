using BelajarCoreThree.Domains.Movie.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BelajarCoreThree
{
    public partial class Startup
    {
        public void Repositories(IServiceCollection services)
        {
            services.AddScoped<MovieRepository>();
        }
    }
}
