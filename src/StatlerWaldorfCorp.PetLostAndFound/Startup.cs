using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace StatlerWaldorfCorp.PetLostAndFound
{
        public class Startup 
    {
        public void ConfigureServices(IServiceCollection services)
        {
	        services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }                
    }
}