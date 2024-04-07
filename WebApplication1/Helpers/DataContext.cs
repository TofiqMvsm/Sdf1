namespace WebApplication1.Helpers
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using WebApplication1.Entities;
 

    public class DataContext : DbContext
    {

     public DataContext(DbContextOptions<DataContext> options): base(options)
        {
          

        }
      




        public DbSet<User> Users { get; set; }
    }
}
