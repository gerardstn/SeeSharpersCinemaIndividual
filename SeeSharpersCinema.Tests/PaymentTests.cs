using SeeSharpersCinema.Models.Order;
using Xunit;

namespace SeeSharpersCinema.Tests
{
    public class PaymentTests
    {
        [Fact]
        public void CanChangeTicketPrice()
        {
            // Arrange
            var t = new Ticket { Price = 8.5 };
            // Act
            t.Price = 1.5;
            // Assert
            Assert.Equal(1.5, t.Price);
        }

        [Fact]
        public void CanChangeMovieId()
        {
            // Arrange
            var i = new Ticket { MovieId = 3 };
            // Act
            i.MovieId = 12;
            // Assert
            Assert.Equal(12, i.MovieId);
        }

        [Fact]
        public void CanChangeTimeSlotId()
        {
            // Arrange
            var i = new Ticket { TimeSlotId = 2 };
            // Act
            i.TimeSlotId = 43;
            // Assert
            Assert.Equal(43, i.TimeSlotId);
        }

        [Fact]
        public void CanChangeCouponId()
        {
            // Arrange
            var i = new Ticket { CouponId = 5 };
            // Act
            i.CouponId = 15;
            // Assert
            Assert.Equal(15, i.CouponId);
        }

        [Fact]
        public void CanChangeCashier()
        {
            // Arrange
            var c = new Ticket { Cashier = "John" };
            // Act
            c.Cashier = "Jane";
            // Assert
            Assert.Equal("Jane", c.Cashier);
        }

        [Fact]
        public void TestTypePrice()
        {
            // Arrange
            Ticket p = new Ticket { Price = 8.5 };

            // Assert
            Assert.IsType<double>(p.Price);
        }

        [Fact]
        public void TestTypeCashier()
        {
            // Arrange
            var c = new Ticket { Cashier = "John" };
            // Assert
            Assert.IsType<string>(c.Cashier);
        }

        [Fact]
        public void TestTypeIds()
        {
            // Arrange
            var i = new Ticket { Id = 1, MovieId = 1, TimeSlotId = 1, CouponId = 1 };

            // Assert
            Assert.IsType<long>(i.Id);
            Assert.IsType<long>(i.MovieId);
            Assert.IsType<long>(i.TimeSlotId);
            Assert.IsType<long>(i.CouponId);
        }


    }
}

