using Sala.Core.Dtos.Requests.SportsHalls;
using Sala.Core.Dtos.Responses.Reservations;
using Sala.Core.Dtos.Responses.SportsHalls;
using Sala.Core.Mapping;
using Sala.Core.Services.Interfaces;
using Sala.Database.Entities;
using Sala.Database.Repositories;

namespace Sala.Core.Services
{

    public class SportsHallService : ISportsHallService
    {
        private readonly SportsHallRepository _repository;

        public SportsHallService(SportsHallRepository repository)
        {
            _repository = repository;
        }
        private readonly ReservationRepository _reservationRepository;

        public SportsHallService(SportsHallRepository repo, ReservationRepository reservationRepo)
        {
            _repository = repo;
            _reservationRepository = reservationRepo;
        }

        public async Task<List<GetReservationResponse>> GetReservationsByHallId(int hallId)
        {
            var reservations = await _reservationRepository.GetBySportsHallIdAsync(hallId);
            return reservations.Select(r => r.ToResponse()).ToList();
        }


        public async Task<List<GetSportsHallResponse>> GetAllAsync()
        {
            var halls = await _repository.GetAllAsync();
            return halls.Select(h => h.ToResponse()).ToList();
        }

        public async Task AddAsync(AddSportsHallRequest request)
        {
            var entity = new SportsHall
            {
                Name = request.Name,
                Location = request.Location
            };
            await _repository.AddAsync(entity);
        }

    }
}
