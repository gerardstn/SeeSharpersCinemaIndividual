namespace SeeSharpersCinema.Models.Order
{
    public class Coupon
    {
        public static double Discount = 0;
        public long Id { get; set; }
        public long TicketId { get; set; }
        public string Type { get; set; }
        public bool IsActive { get; set; }
        public string Code { get; set; }
    }
}
