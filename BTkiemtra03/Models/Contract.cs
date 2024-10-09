using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BTkiemtra03_03.Models
{
    public class Contract
    {
        [Key]
        public int ContractId { get; set; }
        [Required]
        public string ContractName { get; set; }
        [Required]
        public double ContractValue { get; set; }
        public int CustomerId {  get; set; }
        public DateTime SigningDate { get; set; } = DateTime.Now;




    }
}
