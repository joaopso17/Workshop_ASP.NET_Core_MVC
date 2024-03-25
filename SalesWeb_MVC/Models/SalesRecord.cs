using SalesWeb_MVC.Models.Enums;
namespace SalesWeb_MVC.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public double Amount { get; set; }
        public SalesStatus Status { get; set; }
        public Seller saller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SalesStatus status, Seller saller)
        {
            Id = id;
            this.date = date;
            Amount = amount;
            Status = status;
            this.saller = saller;
        }
    }
}
