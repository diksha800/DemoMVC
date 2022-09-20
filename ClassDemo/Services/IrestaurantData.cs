using ClassDemo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo.Services
{
    public interface IrestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        IEnumerable<CustomerInfo> GetCustomerInfos();

        IEnumerable<Address> GetAddresses();

        Restaurant Get(int id);
        void add(Restaurant restaurants);
        void Update(Restaurant restaurants);
        void Delete(int id);

    }


}
