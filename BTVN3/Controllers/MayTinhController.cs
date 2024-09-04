using Microsoft.AspNetCore.Mvc;

namespace BTVN3.Controllers
{
    public class MayTinhController : Controller
    {
        public IActionResult  MayTinh(double a, double b, string pheptinh)
        {
            double ketqua = 0;
            switch (pheptinh)
            {
                case "cong":
                    ketqua = a + b;
                    break;
                case "tru":
                    ketqua = a - b;
                    break;
                case "nhan":
                    ketqua = a * b;
                    break;
                case "chia":
                    if (b != 0)
                    {
                        ketqua = a / b;
                    }
                    else
                    {
                        ViewBag.Error = "Không thể chia cho 0";
                    }
                    break;
                default:
                    ViewBag.Error = "Phép tính không hợp lệ";
                    break;
            }

            ViewBag.KetQua = ketqua;
            return View();
        }
    }
}
