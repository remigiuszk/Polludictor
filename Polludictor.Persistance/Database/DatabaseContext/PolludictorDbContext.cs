using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;

namespace Polludictor.Persistence.Database.DatabaseContext
{
    public class PolludictorDbContext : DbContext
    {
        private readonly IConfiguration _config;

        public PolludictorDbContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(_config["ConnectionStrings:CinemaTicketingContextDb"]);

            optionsBuilder.LogTo(message => Debug.WriteLine(message));
        }


    }
}
