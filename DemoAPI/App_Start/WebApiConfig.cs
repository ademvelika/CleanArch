using Autofac;
using Autofac.Integration.WebApi;
using DemoApplication.Interfaces.UseCases;
using DemoApplication.Respositories;
using DemoApplication.UseCases;
using DemoInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Http;

namespace DemoAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

           

          
            var builder = new ContainerBuilder();
            //Register your Web API controllers.  
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());

         
            builder.RegisterType<GetPersonUseCase>()
                   .As<IGetPersonInteractor>()
                   .InstancePerRequest();
            builder.RegisterType<PersonRespository>()
               .As<IPersonRespository>()
               .InstancePerRequest();


            IContainer container = builder.Build();
            var webApiResolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.DependencyResolver = webApiResolver;

            var formatters = GlobalConfiguration.Configuration.Formatters;

            formatters.Remove(formatters.XmlFormatter);
        }
    }
}
