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
            Ticket t1 = new Ticket { };

            // Act -- Generate the code

            // Assert
            Assert.True(true);
        }
    }
}
