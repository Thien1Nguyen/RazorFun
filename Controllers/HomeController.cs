using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    [HttpGet("")] 
    [HttpGet("index")] 
    public ViewResult Index()
    {
        return View("Index");
    }
}