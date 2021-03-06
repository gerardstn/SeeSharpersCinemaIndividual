using SeeSharpersCinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SeeSharpersCinema.Tests
{
    public class TicketGenerationTests
    {
        [Fact]
        public void Can_Generate_QR_Code()
        {
            // Arrange -- create a Ticket
            Ticket t1 = new Ticket { TicketID = 1, RoomID = 2, SeatNum = 15, Title = "Titel van de film", TimeSlot = DateTime.Now};

            // Act -- Generate the code
            string qr = t1.GetQr();

            // Assert
            Assert.IsType<string>(qr);
            Assert.True(true);
        }

        [Fact]
        public void Can_Print_Tickets()
        {
            // Arrange -- create a Ticket
            Ticket t1 = new Ticket { TicketID = 1, RoomID = 2, SeatNum = 15, Title = "Titel van de film", TimeSlot = DateTime.Now };

            // Act -- Call the print function
            // Logic will come next..

            // Assert
        }
    }
}
