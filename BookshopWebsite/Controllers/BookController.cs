using BookshopWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookshopWebsite.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IActionResult Books()
        {
            var books = _bookRepository.GetBooks();
            return View(books);
        }
    }
}
