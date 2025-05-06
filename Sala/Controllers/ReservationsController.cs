using Microsoft.AspNetCore.Mvc;
using Sala.Core.Dtos.Requests.Reservations;
using Sala.Core.Services.Interfaces;

namespace Sala.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationsController : ControllerBase
    {
        private readonly IReservationService _service;

        public ReservationsController(IReservationService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddReservationRequest request)
        {
            await _service.AddAsync(request);
            return Ok();
        }
    }
}
