using ClassDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo.Services
{
    public class SqlRestaurantData : IrestaurantData
    {
        private ClassDemoDBContext db;

        public SqlRestaurantData(ClassDemoDBContext db)
        {
            this.db = db;
        }
        public void add(Restaurant restaurants)
        {
            db.Restaurants.Add(restaurants);
            db.SaveChanges();
        }

        public Restaurant Get(int id)
        {
            return db.Restaurants.FirstOrDefault(r => r.ID == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in db.Restaurants
                   orderby r.Name
                   select r;
        }

        public void Update(Restaurant restaurant)
        {
            var entry = db.Entry(restaurant);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var restaurant = db.Restaurants.Find(id);
            db.Restaurants.Remove(restaurant);
            db.SaveChanges();
        }

        public IEnumerable<CustomerInfo> GetCustomerInfos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Address> GetAddresses()
        {
            throw new NotImplementedException();
        }
    }
}
