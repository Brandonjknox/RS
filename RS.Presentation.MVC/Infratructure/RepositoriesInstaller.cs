using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using RS.Business.Managers;
using RS.Business.Managers.Contracts;

namespace RS.Presentation.MVC.Infratructure
{
    public class RepositoriesInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
               Classes.FromThisAssembly()
                   .BasedOn<ControllerBase>()
                   .Configure((c => c.LifestyleTransient())));
            container.Register(
    Classes.FromThisAssembly()
        .BasedOn<ApiController>()
        .Configure((c => c.LifestyleTransient())));

            container.Register(Component.For<IImageManager>().ImplementedBy<ImageManager>().LifestyleTransient());
            container.Register(Component.For<ISimpleDataStore>().ImplementedBy<SimpleDataStore>().LifestyleTransient());
            container.Register(Component.For<IGenreManager>().ImplementedBy<GenreManager>().LifestyleTransient());

        }
    }
}