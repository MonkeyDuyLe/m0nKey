using BT06.Models;
using Microsoft.AspNetCore.Mvc;

namespace BT06.Controllers
{
    public class TaiKhoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DangKy(TaiKhoanViewModel taiKhoan)

        {
            {
                if (taiKhoan != null && taiKhoan.PassWord != null && taiKhoan.PassWord.Length > 0)
                {
                    taiKhoan.PassWord = taiKhoan.PassWord + "_da_ma_hoa";
                }
                return View(taiKhoan);
            }
            return View(taiKhoan);
        }
    }
}
