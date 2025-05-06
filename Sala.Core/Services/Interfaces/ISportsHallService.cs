using Sala.Core.Dtos.Requests.SportsHalls;
using Sala.Core.Dtos.Responses.Reservations;
using Sala.Core.Dtos.Responses.SportsHalls;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sala.Core.Services.Interfaces
{



    public interface ISportsHallService
    {
        Task<List<GetSportsHallResponse>> GetAllAsync();
        Task<List<GetReservationResponse>> GetReservationsByHallId(int hallId);

        Task AddAsync(AddSportsHallRequest request);
    }

}
