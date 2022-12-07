using Microsoft.EntityFrameworkCore;
using StockData.Infrastructure.Entities;

namespace StockData.Infrastructure.DbContexts
{
    public interface IApplicationDbContext
    {
        DbSet<Company> Companies { get; set; }
    }
}