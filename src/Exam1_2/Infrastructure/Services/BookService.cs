using Infrastructure.DbContexts;
using Infrastructure.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookBO = Infrastructure.BusinessObjects.Book;
using BookEO = Infrastructure.Entities.Book;

namespace Infrastructure.Services
{
    public class BookService : IBookService
    {
        private readonly IApplicationUnitOfWork _applicationUnitOfWork;
        public BookService(IApplicationUnitOfWork applicationUnitOfWork)
        {
            _applicationUnitOfWork = applicationUnitOfWork;
        }
        public void CreateBook(BookBO book)
        {
            BookEO bookEntity = new BookEO();
            bookEntity.Name = book.Name;
            bookEntity.PublicationName = book.PublicationName;

            _applicationUnitOfWork.Books.Add(bookEntity);
            _applicationUnitOfWork.Save();
        }
    }
}
