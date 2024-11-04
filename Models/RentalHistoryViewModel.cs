﻿namespace Carrental.WebAPI.Models
{
    public class RentalHistoryViewModel
    {
        public int BookingId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Place { get; set; }
        public DateTime? ActualReturnDate { get; set; }
        public string DamageReported { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; }
        public int Rating { get; set; }



    }
}
