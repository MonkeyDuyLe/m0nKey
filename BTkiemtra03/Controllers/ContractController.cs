using BTkiemtra03.Data;
using BTkiemtra03_03.Models;
using Microsoft.AspNetCore.Mvc;

namespace BTkiemtra03_03.Controllers
{
	public class ContractController : Controller
	{
		private readonly ApplicationDbContext _db;
		public ContractController(ApplicationDbContext db)
		{

			_db = db;
		}
		public IActionResult Index()
		{
			var contract = _db.Contract.ToList();
			ViewBag.contract = contract;
			return View();
		}
		[HttpGet]
		public IActionResult Create()
		{

			return View();
		}
		[HttpPost]
		public IActionResult Create(Contract contract)
		{
			if (ModelState.IsValid)
			{

				//Thêm thông tin vào bảng thể loại
				_db.Contract.Add(contract);
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
			var contract = _db.Contract.Find(id);
			return View(contract);
		}


		[HttpGet]
		public IActionResult Delete(int id)
		{
			if (id == 0)
			{
				return NotFound();
			}
			var contract = _db.Contract.Find(id);
			return View(contract);
		}

		[HttpPost]
		public IActionResult DeleteConfirm(int id)
		{
			var contract = _db.Contract.Find(id);
			if (contract == null)
			{
				return NotFound();
			}
			_db.Contract.Remove(contract);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult Detail(int id)
		{
			if (id == 0)
			{
				return NotFound();
			}
			var contract = _db.Contract.Find(id);


			return View(contract);
		}
		[HttpGet]
		public IActionResult Search(String searchString)
		{
			if (!String.IsNullOrEmpty(searchString))
			{
				//Sử dung LNIQ
				var contract = _db.Contract.
					Where(tl => tl.ContractName.Contains(searchString)).ToList();
				ViewBag.SearchString = searchString;
				ViewBag.Theloai = contract;

			}
			else
			{
				var contract = _db.Contract.ToList();
				ViewBag.Theloai = contract;
			}
			return View("Index");


		}

	}
}
