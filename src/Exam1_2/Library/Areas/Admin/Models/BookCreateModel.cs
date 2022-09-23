using Autofac;
using Infrastructure.BusinessObjects;
using Infrastructure.Services;
using System.ComponentModel.DataAnnotations;

namespace Library.Areas.Admin.Models
{
    public class BookCreateModel
    {
        [Required]
        public string Name { get; set; }
        public string PublicationName { get; set; }
        private  IBookService _bookService;
        private  ILifetimeScope _scope;

        public BookCreateModel()
        {

        }
        public BookCreateModel(IBookService bookService)
        {
            _bookService = bookService;
        }

        internal void ResolveDependency(ILifetimeScope scope)
        {
            _scope = scope;
            _bookService = _scope.Resolve<IBookService>();
        }

        internal async Task CreateBook()
        {
            Book book = new Book();
            book.Name = Name;
            book.PublicationName = PublicationName;
            _bookService.CreateBook(book);
        }
    }
}
