using Sala.Core.Dtos.Requests.Reservations;
using Sala.Core.Dtos.Responses.Reservations;
using Sala.Core.Mapping;
using Sala.Core.Services.Interfaces;
using Sala.Database.Entities;
using Sala.Database.Repositories;

namespace Sala.Core.Services
{

    public class ReservationService : IReservationService
    {
        private readonly ReservationRepository _repository;

        public ReservationService(ReservationRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetReservationResponse>> GetAllAsync()
        {
            var reservations = await _repository.GetAllAsync();
            return reservations.Select(r => r.ToResponse()).ToList();
        }

        public async Task AddAsync(AddReservationRequest request)
        {
            var entity = new Reservation
            {
                StartTime = request.StartTime,
                EndTime = request.EndTime,
                SportsHallId = request.SportsHallId

            };
            await _repository.AddAsync(entity);
        }

    }
}

