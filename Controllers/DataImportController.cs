using Microsoft.AspNetCore.Mvc;

namespace CSV_to_Database.Controllers
{
    public class DataImportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ManageData()
        {
            return View();
        }
    }
}
