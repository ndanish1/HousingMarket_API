using Microsoft.AspNetCore.Mvc;

namespace HousingMarket_API.Repository
{
    public class UserRepository : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
