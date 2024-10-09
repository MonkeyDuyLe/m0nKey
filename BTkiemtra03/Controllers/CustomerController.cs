using BTkiemtra03.Data;
using BTkiemtra03_03.Models;
using Microsoft.AspNetCore.Mvc;

namespace BTkiemtra03_03.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CustomerController(ApplicationDbContext db)
        {

            _db = db;
        }
        public IActionResult Index()
        {
            var customer = _db.Contract.ToList();
            ViewBag.customer = customer;
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {

                //Thêm thông tin vào bảng thể loại
                _db.Customer.Add(customer);
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
            var customer = _db.Customer.Find(id);
            return View(customer);
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var customer = _db.Customer.Find(id);
            return View(customer);
        }

        [HttpPost]
  
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
                var customer = _db.Customer.
                    Where(tl => tl.CustomerName.Contains(searchString)).ToList();
                ViewBag.SearchString = searchString;
                ViewBag.Theloai = customer;

            }
            else
            {
                var customer = _db.Customer.ToList();
                ViewBag.Theloai = customer;
            }
            return View("Index");


        }

    }
}
