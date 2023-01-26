using Microsoft.EntityFrameworkCore;
using Polludictor.API.DependencyIncjection;
using Polludictor.Persistence.Database.DatabaseContext;

namespace Polludictor.API
{
    public class Startup
    {
        private IConfiguration? _configuration;

        public void AddConfiguration(ConfigurationManager configurationManager)
        {
            _configuration = configurationManager.SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .AddEnvironmentVariables().Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddDbContext<PolludictorDbContext>(cfg =>
            {
                cfg.UseSqlServer();
            });

            services.AddCustomServices(_configuration!);
        }

        public void Configure(WebApplication app)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }

    }
}
