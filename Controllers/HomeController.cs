using Microsoft.AspNetCore.Mvc;
using mission11_benZapata4_6.Models;
using mission11_benZapata4_6.Models.ViewModels;
using System.Diagnostics;

namespace mission11_benZapata4_6.Controllers
{
    public class HomeController : Controller
    {

        private IBookRepository _repo;
        public HomeController(IBookRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum = 1)
        {
            int pageSize = 10;

            var booksViewModel = new BooksListViewModel
            {
                Books = _repo.Books
                    .OrderBy(x => x.Title)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }

            };

            return View(booksViewModel);
        }
    }
}
