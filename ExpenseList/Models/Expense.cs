using System.ComponentModel.DataAnnotations;

namespace ExpenseList.Models
{
    public class Expense
    {
        public int ID { get; set; }
        public string? Description { get; set; }
        public decimal Amount { get; set; }
        public string? Category { get; set; }
    }
}