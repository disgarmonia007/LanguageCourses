using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnionApp.Domain.Core;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LanguageCourses.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new OnionApp.Domain.Core.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        private readonly UnitOfWork unit;

        public HomeController(UnitOfWork unit)
        {
            this.unit = unit;
        }
        public async Task<IActionResult> Indexx(int page = 1)
        {
            int pageSize = 3;   // количество элементов на странице

            IQueryable<User> source = (IQueryable<User>)unit.Users.GetList().ToList();
            var count = await source.CountAsync();
            var items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();

            PageViewModel pageViewModel = new PageViewModel(count, page, pageSize);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Users = items
            };
            return View(viewModel);
        }
    }
}
