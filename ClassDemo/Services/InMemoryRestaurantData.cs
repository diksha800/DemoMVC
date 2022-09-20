using ClassDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassDemo.Services
{
    public class InMemoryRestaurantData : IrestaurantData
    {
       
            List<Restaurant> restaurants;
            public InMemoryRestaurantData ()
            {
            restaurants = new List<Restaurant>()
                {
                    new Restaurant{ID=1,Name="JAHANKAR", Cuising=CuisingType.Indian},
                    new Restaurant{ID=2,Name="DOMINOZZ", Cuising=CuisingType.Italian},
                    new Restaurant{ID=3,Name="SWIGGY", Cuising=CuisingType.French},
                    new Restaurant{ID=4,Name="ZOMATO", Cuising=CuisingType.Indian}


                };
            
        }
        public void add(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
            restaurant.ID = restaurants.Max(r => r.ID) + 1;
        }
        public void Update(Restaurant restaurant)
        {
            var Existing = Get(restaurant.ID);
            if(Existing !=null)
            {
                Existing.Name = restaurant.Name;
            }
        }

        public Restaurant Get(int id)
        {
            
            return restaurants.FirstOrDefault(r => r.ID == id);
       
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }

        public void Delete(int id)
        {
            var restaurant = Get(id);
            restaurants.Remove(restaurant);
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
