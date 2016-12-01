using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using StatlerWaldorfCorp.PetLostAndFound.Persistence;

namespace StatlerWaldorfCorp.PetLostAndFound
{
        public class Startup 
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IPetLostAndFoundRepository, MemroyPetLostAndFoundRepository>();            
	        services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }                
    }
}