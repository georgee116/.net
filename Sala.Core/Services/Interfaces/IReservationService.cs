using Sala.Core.Dtos.Requests.Reservations;
using Sala.Core.Dtos.Responses.Reservations;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sala.Core.Services.Interfaces
{

    public interface IReservationService
    {
        Task<List<GetReservationResponse>> GetAllAsync();
        Task AddAsync(AddReservationRequest request);
    }
}

