// КЛАСС ПЛАТЕЖ 
using System;

namespace LAB_8.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public string PaymentName { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Price { get; set; }
        public int PayerId { get; set; }
    }
}
