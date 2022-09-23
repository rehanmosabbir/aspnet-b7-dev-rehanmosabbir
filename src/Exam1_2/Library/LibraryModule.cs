using Autofac;
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
            base.Load(builder);
        }
    }
}
