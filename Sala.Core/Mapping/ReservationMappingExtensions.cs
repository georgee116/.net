using Sala.Core.Dtos.Responses.Reservations;
using Sala.Database.Entities;

namespace Sala.Core.Mapping
{
    public static class ReservationMappingExtensions
    {
        public static GetReservationResponse ToResponse(this Reservation reservation)
        {
            return new GetReservationResponse
            {
                Id = reservation.Id,
                StartTime = reservation.StartTime,
                EndTime = reservation.EndTime,
                SportsHallName = reservation.SportsHall?.Name ?? ""

            };
        }
    }
}
