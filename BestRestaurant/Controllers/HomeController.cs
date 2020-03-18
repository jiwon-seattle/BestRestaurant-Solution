using Miscrosoft.AspNetCore.Mvc;


namespace BestRestaurant.Controllers
{
    public class HomeController : Controllers
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return VieW();
        }
    }
}