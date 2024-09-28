using baikiemtaso2.Data;
using baikiemtaso2.Models;
using Microsoft.AspNetCore.Mvc;

namespace baikiemtaso2.Controllers
{
	public class LopHocController : Controller
	{
		private readonly ApplicationDbContext _db;
		public LopHocController(ApplicationDbContext db)
		{

			_db = db;
		}
		public IActionResult Index()
		{
			var lophoc = _db.LopHoc.ToList();
			ViewBag.lophoc = lophoc;
			return View();
		}
		[HttpGet]
		public IActionResult Create()
		{

			return View();
		}
		[HttpPost]
		public IActionResult Create(LopHoc lopHoc)
		{
			if (ModelState.IsValid)
			{

				//Thêm thông tin vào bảng thể loại
				_db.LopHoc.Add(lopHoc);
				//Lưu lại
				_db.SaveChanges();

				return RedirectToAction("Index");

			}
			return View();

		}
		[HttpGet]
		public IActionResult Edit(int id)
		{
			if (id == 0)
			{
				return NotFound();
			}
			var theloai = _db.LopHoc.Find(id);
			return View(theloai);
		}

		[HttpPost]
		public IActionResult Edit(LopHoc lophoc)
		{
			if (ModelState.IsValid)
			{
				// Thêm thông tin vào bảng TheLoai
				_db.LopHoc.Update(lophoc);
				// Lưu lại
				_db.SaveChanges();
				// Chuyển trang về index
				return RedirectToAction("Index");
			}
			return View();
		}

		[HttpGet]
		public IActionResult Delete(int id)
		{
			if (id == 0)
			{
				return NotFound();
			}
			var theloai = _db.LopHoc.Find(id);
			return View(theloai);
		}

		[HttpPost]
		public IActionResult DeleteConfirm(int id)
		{
			var theloai = _db.LopHoc.Find(id);
			if (theloai == null)
			{
				return NotFound();
			}
			_db.LopHoc.Remove(theloai);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult Detail(int id)
		{
			var theloai = _db.LopHoc.Find(id);
			if (theloai == null)
			{
				return NotFound();
			}

			return View();
		}
	}
}
