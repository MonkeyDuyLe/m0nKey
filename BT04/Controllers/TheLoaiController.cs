using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR.Protocol;

namespace BT04.Controllers
{
    public class TheLoaiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Edit(int id)
        {
            return Ok("id :" + id);
        }
        public IActionResult Detail(int id, string ten)
        {
            //return Content("id :" + id+"Ten :"+ten);
            return Content(String.Format("id: {0}; ten: {1}",id ,ten)) ;
        }
        public IActionResult Show(List<string>categories)
        {
            string content = "Danh sách thể loại";
            foreach(var category in categories)
            {
                content = content + " " + category + ",";
            }    
            return Content(content);
        }
    }
}
