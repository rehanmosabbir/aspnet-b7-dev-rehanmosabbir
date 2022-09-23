using Autofac;
using Library.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookController : Controller
    {
        private readonly ILifetimeScope _scope;
        private readonly ILogger<BookController> _logger;
        public BookController(ILogger<BookController> logger, ILifetimeScope scope)
        {
            _scope = scope;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            BookCreateModel model = _scope.Resolve<BookCreateModel>();
            return View(model);
        }
        [HttpPost,ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BookCreateModel model)
        {
            if(ModelState.IsValid)
            {
                model.ResolveDependency(_scope);
                await model.CreateBook();
            }
            return View(model);
        }
    }
}
