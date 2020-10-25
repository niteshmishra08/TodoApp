using System.Web.Mvc;
using AutoMapper;
using Data.Common;
using FirstApp.App_Start;
using Microsoft.Practices.Unity;
using Unity.Mvc4;

namespace FirstApp
{
    public static class UnityConfig
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            RegisterTypes(container);

            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            // e.g. container.RegisterType<ITestService,estService>();    
            container.RegisterType<IUnitOfWork, UnitOfWork>();
          
            RegisterAutoMapperConfig(container);
        }



        private static void RegisterAutoMapperConfig(IUnityContainer container)
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile(new AutomapperConfig()));
            var mapper = config.CreateMapper();
            container.RegisterInstance<IMapper>(mapper);
        }
    }
}