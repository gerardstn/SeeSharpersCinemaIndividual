using SeeSharpersCinema.Models.Order;
using Xunit;

namespace SeeSharpersCinema.Tests
{
    public class CouponTests
    {

        [Fact]
        public void TestCouponTypeIsActiveIsABoolean()
        {
            // Arrange
            var c = new Coupon { IsActive = true };

            // Assert
            Assert.IsType<bool>(c.IsActive);
        }

        [Fact]
        public void TestActiveCouponSetsTicketPriceToZero()
        {
            var ticket = new Ticket();
            ticket.Price = 10;

            var coupon = new Coupon();
            coupon.IsActive = true;

            ticket.TryAddCoupon(coupon);

            Assert.Equal(0, ticket.Price);
        }

        [Fact]
        public void TestInactiveCouponDoesNotTouchTicketPrice()
        {
            var ticket = new Ticket();
            ticket.Price = 15;

            var coupon = new Coupon();
            coupon.IsActive = false;

            ticket.TryAddCoupon(coupon);

            Assert.Equal(15, ticket.Price);
        }

    }
}