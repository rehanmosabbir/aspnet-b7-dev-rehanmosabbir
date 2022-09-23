using Library.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            BookCreateModel model = new BookCreateModel();
            return View(model);
        }
        [HttpPost,ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BookCreateModel model)
        {
            if(ModelState.IsValid)
            {
                await model.CreateBook();
            }
            return View(model);
        }
    }
}
