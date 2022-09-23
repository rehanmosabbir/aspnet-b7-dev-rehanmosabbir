using Infrastructure.BusinessObjects;

namespace Infrastructure.Services
{
    public interface IBookService
    {
        void CreateBook(Book book);
    }
}