using SeeSharpersCinema.Models.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeeSharpersCinema.Models.Repository
{
    public class OrderRepository
    {
        private static List<TicketResponse> responses = new List<TicketResponse>();
        public static IEnumerable<TicketResponse> Responses => responses;
        public static void AddResponse(TicketResponse response)
        {
            responses.Add(response);
        }
    }
}
