using Autofac;
using Library.Areas.Admin.Models;
using Library.Models;

namespace Library
{
    public class LibraryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BookModel>().As<IBookModel>()
                .InstancePerLifetimeScope();
            builder.RegisterType<BookModel>().AsSelf();
            builder.RegisterType<BookCreateModel>().AsSelf();
            base.Load(builder);
        }
    }
}
