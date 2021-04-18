namespace SeeSharpersCinema.Models.Order
{
    public class Coupon
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public bool IsActive { get; set; }
        public string Code { get; set; }
    }
}
