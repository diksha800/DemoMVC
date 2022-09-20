using Autofac;
using Autofac.Integration.Mvc;
using ClassDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.NETMVC.web
{
    public class ContainerConfig
    {


        internal static void RegisterContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<SqlRestaurantData>().As<IrestaurantData>()
                .InstancePerRequest();
            builder.RegisterType<ClassDemoDBContext>();
            var Container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(Container));
        }
    }
}