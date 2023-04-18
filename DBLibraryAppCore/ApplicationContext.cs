using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLibraryAppCore
{
    public class ApplicationContext:DbContext
    {
        public static string connectionstring = "Host=localhost;Port=8080;Database=userdb;Username=postgres;Password=1234";
        public DbSet<Book> books => Set<Book>();
        public DbSet<User> users => Set<User>();
        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionstring);
        }
    }
}
