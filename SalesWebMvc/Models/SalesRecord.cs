using SalesWebMvc.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public Double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, Double amount, SaleStatus status, Seller seller)
        {
            Id =     id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
