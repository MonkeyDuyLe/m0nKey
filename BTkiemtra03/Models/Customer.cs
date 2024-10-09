namespace BTkiemtra03_03.Models
{
    public class Customer
    {public int CustomerId {  get; set; }
     public string CustomerName { get; set; }
        public string Address {  get; set; }
        public string PhoneNumber {  get; set; }
    public string CustomerEmail { get; set; }
        public ICollection<Contract> Contracts { get; set; }
    }
}
