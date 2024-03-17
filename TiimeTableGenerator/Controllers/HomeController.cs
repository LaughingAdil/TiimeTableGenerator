using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TiimeTableGenerator.Models;

namespace TiimeTableGenerator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AddDbContext _context;
        public HomeController(ILogger<HomeController> logger, AddDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            // Initialize the model with default values or retrieve values from a data source
            /* var model = new TimeTableInput
             {
                 NumberOfClassRooms = 0,
                 NumberOfPeriods = 0,
                 NumberOfSubjects = 0,
                 Subjects = new List<string>()
             };*/

            return View();
        }
       
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult GenerateTimeTable(TimeTableInput model)
        {
            if (ModelState.IsValid)
            {
                // Assuming _context is your database context
                _context.TimeTableInputTable.Add(model);
                _context.SaveChanges();

                // Redirect or perform other actions as needed
                return View(model); // Replace "Index" with the desired action
            }

            // If the model state is not valid, return to the view with the model to display validation errors


            return RedirectToAction("Index");
        }

    }
}
