using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using OA.Repository;
using OA.Service;

namespace Onion_Architecture
{
    public class StartUp
    {
        
        IConfiguration configuration;

        public void config(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void ConfigureService(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<ApplicationContext>(s => s.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserInfoService, UserInfoService>();
        }
    }
}
