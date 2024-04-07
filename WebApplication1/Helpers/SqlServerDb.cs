using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace WebApplication1.Helpers
{
    public class MsSqlDataContext : DataContext
    {
        private readonly IConfiguration _configuration;

        public MsSqlDataContext(DbContextOptions<DataContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("MsSqlServerConnection"));
        }
    }
}
