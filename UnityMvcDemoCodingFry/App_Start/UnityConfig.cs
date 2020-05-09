using System.Web.Mvc;
using Unity;
using Unity.Lifetime;
using Unity.Mvc5;
using UnityMvcDemoCodingFry.Models;

namespace UnityMvcDemoCodingFry
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<IEmployeeService, EmployeeService>();

            //container.RegisterSingleton<IEmployeeService, EmployeeService>();

            //container.RegisterType<IEmployeeService, EmployeeService>(new PerResolveLifetimeManager());

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}