using BT05.Models;
using Microsoft.AspNetCore.Mvc;

namespace BT05.Controllers
{
    public class TheLoaiController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Ngay = "Ngày 24";
            ViewBag.Thang = "Tháng 12";
            ViewData["Nam"] = "Năm 2004 ";
            return View();
        }
        public IActionResult Index2()
        {
            var TheLoai = new TheLoaiViewModel
            {
                Id = 1,
                Name = "Trinh Thám"
            };
            return View(TheLoai);
        }
    }
}
