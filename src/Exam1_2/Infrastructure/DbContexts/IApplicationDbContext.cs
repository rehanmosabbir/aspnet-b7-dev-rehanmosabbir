using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DbContexts
{
    public interface IApplicationDbContext
    {
        DbSet<Book> Books { get; set; }
        DbSet<Reader> Readers { get; set; }
    }
}