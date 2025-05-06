using System;

namespace Sala.Core.Dtos.Requests.Reservations
{
    public class AddReservationRequest
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int SportsHallId { get; set; }
    
    }
}
