using BT07.Data;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

namespace BT07.Models
{
    public class TheLoaiController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TheLoaiController(ApplicationDbContext db)
        {

            _db = db;
        }
        public IActionResult Index()
        {
            var theloai =_db.TheLoai.ToList();
            ViewBag.theloai=theloai;
            return View();
        }
        [HttpGet]      
        public IActionResult Create()
		{
			
			return View();
		}
		[HttpPost]
		public IActionResult Create(TheLoai theLoai)
		{
            //Thêm thông tin vào bảng thể loại
            _db.TheLoai.Add(theLoai);
            //Lưu lại
            _db.SaveChanges();

			return View();
		}
	}
}
