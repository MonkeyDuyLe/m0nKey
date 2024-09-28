using System.ComponentModel.DataAnnotations;

namespace baikiemtaso2.Models
{
	public class LopHoc
	{

		[Key]
		public int Id { get; set; }
		public int SoLuongSinhVien { get; set; }
		[Required(ErrorMessage = "Không được để trống số lượng sinh viên!")]
		[Display(Name = "Số lượng sinh viên")]

		public DateTime NamNhapHoc { get; set; } = DateTime.Now;

		public DateTime NamRaTruong { get; set; } = DateTime.Now;

		public string Name { get; set; }
		[Required(ErrorMessage = "Không được để trống tên lớp học!")]
		[Display(Name = "Lớp học")]

		public string Description { get; set; }


	}
}
