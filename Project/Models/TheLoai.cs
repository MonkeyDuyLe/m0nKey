using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    [Area("Customer")]
    public class TheLoai
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Không đc để trống tên thể loại!")]
        [Display(Name="Thể Loại")]
  
        public string Name { get; set; }
        [Required(ErrorMessage ="Không đúng định dạng ngày!")]
        [Display(Name="Ngày tạo")]
 

        public DateTime DateCreated { get; set; }= DateTime.Now;
    }
}


