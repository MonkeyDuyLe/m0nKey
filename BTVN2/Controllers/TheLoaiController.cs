using Microsoft.AspNetCore.Mvc;

namespace BTVN2.Controllers
{
    public class TheLoaiController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HoTen = "Lê Thành Duy";
            ViewBag.MSSV = "1822040141";
            ViewData["Nam"] = "Năm 2004 ";
            return View();
       
        }   
    }
}
