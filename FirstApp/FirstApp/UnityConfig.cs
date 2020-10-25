using System.Web.Mvc;
using Data.Common;
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

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            // e.g. container.RegisterType<ITestService,estService>();    
            container.RegisterType<IUnitOfWork, UnitOfWork>();
      RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
    
    }
  }
}