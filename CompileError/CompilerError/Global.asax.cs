using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using CompileError.Model.Model;
using CompilerError.Models;

namespace CompilerError
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<CustomerViewModel, Customer>();
                cfg.CreateMap<Customer, CustomerViewModel>();

                cfg.CreateMap<SalesViewModel, Customer>();
                cfg.CreateMap<Customer, SalesViewModel>();

                cfg.CreateMap<SalesViewModel, Category>();
                cfg.CreateMap<Category, SalesViewModel>();

                cfg.CreateMap<SalesViewModel, Product>();
                cfg.CreateMap<Product, SalesViewModel>();

                cfg.CreateMap<SalesViewModel, PurchaseDetail>();
                cfg.CreateMap<PurchaseDetail, SalesViewModel>();

                cfg.CreateMap<SalesViewModel, SalesDetail>();
                cfg.CreateMap<SalesDetail, SalesViewModel>();

                cfg.CreateMap<SalesReportViewModel, Sale>();
                cfg.CreateMap<Sale, SalesReportViewModel>();

                cfg.CreateMap<SalesReportViewModel, PurchaseDetail>();
                cfg.CreateMap<PurchaseDetail, SalesReportViewModel>();

            });
        }
    }
}
