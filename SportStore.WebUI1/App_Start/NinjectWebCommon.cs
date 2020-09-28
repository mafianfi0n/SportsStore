using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportStore.WebUI1.App_Start
{
    
    public class NinjectWebCommon
    {
        private static void RegisterServices(IKernel kernel)
        {
            System.Web.Mvc.DependencyResolver.SetResolver(new SportsStore.WebUI.Infrastructure.NinjectDependencyResolver(kernel));
        }
    }
}