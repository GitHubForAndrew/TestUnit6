using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using TestUnit6.Infrastructure.Abstract;
using TestUnit6.Repository.Interface;
using TestUnit6.Infrastructure.Concrete;
using TestUnit6.Repository;

namespace TestUnit6.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }


        private void AddBindings()
        {
            ninjectKernel.Bind<IAuhtProvider>().To<FormsAuthProvider>();
        }
    }
}
