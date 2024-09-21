using System.ComponentModel.DataAnnotations;

namespace BT07.Models
{
    public class TheLoai
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Không đc để trống tên thể loại!")]
        [Display(Name="Thể Loại")]
  
        public string Name { get; set; }
        [Required(ErrorMessage ="Không đúng định dạng ngày!")]
        [Display(Name="Ngày tạo")]
        public string Description { get; set; }

        public DateTime DateCreated { get; set; }= DateTime.Now;
    }
}


