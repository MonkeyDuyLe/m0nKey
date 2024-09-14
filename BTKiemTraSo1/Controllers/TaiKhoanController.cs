using BTKiemTraSo1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BTKiemTraSo1.Controllers
{
    public class TaiKhoanController : Controller
    {
        public IActionResult DangKy(TaiKhoanViewModel TaiKhoan)
        {
            {
                if (TaiKhoan != null && TaiKhoan.Password != null && TaiKhoan.Password.Length > 0)
                {
                    TaiKhoan.Password = TaiKhoan.Password + "_da_ma_hoa";
                }
                return View(TaiKhoan);
            }
            return View();
        }
        public IActionResult BaiTap2()
        {
            var sanpham = new SanPhamViewModel()
            {
                TenSanPham ="LapTop Gaming MonKey",
                Price=99999.9999m,
                MoTaSanPham="Lap Top gaming hiệu MonKey có thể chơi mọi game Triple A mà bạn cần. ",
                ImageUrl = "/images/LapTop.png" // Đường dẫn ảnh

            };
          
            return View(sanpham);
        }
    }
}
