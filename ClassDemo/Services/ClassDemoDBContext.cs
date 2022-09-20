using ClassDemo.Models;
using System.Data.Entity;

namespace ClassDemo.Services
{
    public class ClassDemoDBContext:DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<CustomerInfo> customerInfos { get; set; }

        public DbSet<Address> addresses { get; set; }

    }
}
