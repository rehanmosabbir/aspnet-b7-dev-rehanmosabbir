using Autofac;
using StockData.Infrastructure.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockData.Infrastructure
{
    public class InfrastructureModule : Module
    {
        private readonly string _connectionString;
        private readonly string _assemblyName;
        public InfrastructureModule(string connectionString, string assemblyName)
        {
            _connectionString = connectionString;
            _assemblyName = assemblyName;
        }
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<ApplicationDbContext>().AsSelf().
                WithParameter("connectionString", _connectionString).
                WithParameter("migrationAssemblyName", _assemblyName)
                .InstancePerLifetimeScope();
            builder.RegisterType<ApplicationDbContext>().As<IApplicationDbContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _assemblyName)
                .InstancePerLifetimeScope();
            /*
            builder.RegisterType<CourseModel>().AsSelf();
            builder.RegisterType<CourseCreateModel>().AsSelf();
            builder.RegisterType<CourseEditModel>().AsSelf();
            builder.RegisterType<CourseListModel>().AsSelf();
            builder.RegisterType<RegisterModel>().AsSelf();
            builder.RegisterType<LoginModel>().AsSelf();
            */
            base.Load(builder);
        }
    }
}
