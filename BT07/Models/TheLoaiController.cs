﻿using BT07.Data;
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
            if (ModelState.IsValid)
            {

                //Thêm thông tin vào bảng thể loại
                _db.TheLoai.Add(theLoai);
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
            var theloai = _db.TheLoai.Find(id);
            return View(theloai);
        }

        [HttpPost]
        public IActionResult Edit(TheLoai theloai)
        {
            if (ModelState.IsValid)
            {
                // Thêm thông tin vào bảng TheLoai
                _db.TheLoai.Update(theloai);
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
            var theloai = _db.TheLoai.Find(id);
            return View(theloai);
        }

        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            var theloai = _db.TheLoai.Find(id);
            if (theloai == null)
            {
                return NotFound();
            }
            _db.TheLoai.Remove(theloai);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
		public IActionResult Detail(int id)
		{
            var theloai=_db.TheLoai.Find(id);
            if(theloai == null)
            {
                return NotFound();
            }    

			return View();
		}
	}
}
