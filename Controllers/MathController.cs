using Microsoft.AspNetCore.Mvc;

namespace TodoList.Controllers
{
    public class MathController : Controller
    {
        public JsonResult Sum(int x, int y)
        {
           return Json(new
            {
                sum = x + y
            });
        }
    }
}
