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

            Mapper.CreateMap<Client, ClientInfoViewModel>()
                .ForMember(x => x.VisitCount, y => y.MapFrom(z => z.Visits.Count));

            Mapper.CreateMap<Client, VisitViewModel>()
                .ForMember(x => x.ClientId, y => y.MapFrom(z => z.Id));

            Mapper.CreateMap<VisitViewModel, Visit>();
            Mapper.CreateMap<Visit, VisitViewModel>()
                .ForMember(x => x.ClientId, y => y.MapFrom(z => z.Client.Id))
                .ForMember(x => x.FirstName, y => y.MapFrom(z => z.Client.FirstName))
                .ForMember(x => x.LastName, y => y.MapFrom(z => z.Client.LastName));
        }
    }
}
