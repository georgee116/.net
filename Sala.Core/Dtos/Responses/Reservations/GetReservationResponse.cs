using System;

namespace Sala.Core.Dtos.Responses.Reservations
{
    public class GetReservationResponse
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public string SportsHallName { get; set; }
    }
}
