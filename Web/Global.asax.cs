using AutoMapper;
using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Web.Models;

namespace Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Database.SetInitializer(new CreateDatabaseIfNotExists<DatabaseContext>());

            Mapper.CreateMap<Visit, VisitDetailsViewModel>();
            Mapper.CreateMap<ClientViewModel, Client>();
            Mapper.CreateMap<Client, ClientViewModel>();
            Mapper.CreateMap<Client, ClientDetailsViewModel>();
            Mapper.CreateMap<Client, ClientInfoViewModel>();
            Mapper.CreateMap<Client, VisitViewModel>();
            Mapper.CreateMap<VisitViewModel, Visit>();
            Mapper.CreateMap<Visit, VisitViewModel>();
        
        }
    }
}
