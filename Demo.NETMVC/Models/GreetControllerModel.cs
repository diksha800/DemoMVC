using ClassDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.NETMVC.Models
{
    public class GreetControllerModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
    }
}