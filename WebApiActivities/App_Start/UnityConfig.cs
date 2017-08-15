using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Web.Http;
using Unity.WebApi;

namespace Ticapps.WebApi.Activities
{
    public static class UnityConfig
    {
        /// <summary>
        /// Registers the components.
        /// </summary>
        /// <returns></returns>
        public static IUnityContainer RegisterComponents()
        {
            IUnityContainer container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.LoadConfiguration();

            return container;
        }
    }
}