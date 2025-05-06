using Microsoft.AspNetCore.Mvc;
using Sala.Core.Dtos.Requests.SportsHalls;
using Sala.Core.Services.Interfaces;

namespace Sala.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SportsHallsController : ControllerBase
    {
        private readonly ISportsHallService _service;

        public SportsHallsController(ISportsHallService service)
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
        public async Task<IActionResult> Add([FromBody] AddSportsHallRequest request)
        {
            await _service.AddAsync(request);
            return Ok();
        }

        [HttpGet("{id}/reservations")]
        public async Task<IActionResult> GetReservationsForHall(int id)
        {
            var result = await _service.GetReservationsByHallId(id);
            return Ok(result);
        }

    }
}
