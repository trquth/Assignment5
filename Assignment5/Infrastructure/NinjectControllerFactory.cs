using Assignment5.BUL;
using Assignment5.DAL.Abstract;
using Assignment5.DAL.Concrete;
using Assignment5.DAL.Models;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment5.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;
        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)ninjectKernel.Get(controllerType);
        }
        private void AddBindings()
        {
            ninjectKernel.Bind<IBookRepository>().To<BookRepository>();
            ninjectKernel.Bind<ICategoryRepository>().To<CategoryRepository>();
            ninjectKernel.Bind<IUserRepository>().To<UserRepository>();
            ninjectKernel.Bind<IBookManagerService>().To<BookManagerService>();
            ninjectKernel.Bind<IUserManagerService>().To<UserManagerService>();
            ninjectKernel.Bind<ICategoryManagerService>().To<CategoryManagerService>();
            ninjectKernel.Bind<IAuthorRepository>().To<AuthorRepository>();
            ninjectKernel.Bind<IAuthorManagerService>().To<AuthorManagerService>();
            ninjectKernel.Bind<BookMNGTContext>().ToMethod<BookMNGTContext>((a) => new BookMNGTContext()).InSingletonScope();
        }
    }
}