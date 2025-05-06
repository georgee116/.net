using Microsoft.EntityFrameworkCore;
using Sala.Database.Context;
using Sala.Database.Entities;

namespace Sala.Database.Repositories
{
    public class ReservationRepository : BaseRepository<Reservation>
    {
        public ReservationRepository(SalaDatabaseContext context) : base(context)
        {
        }
        public async Task<List<Reservation>> GetBySportsHallIdAsync(int hallId)
        {
            return await _context.Reservations
                .Include(r => r.SportsHall)
                .Where(r => r.SportsHallId == hallId)
                .ToListAsync();
        }

    }
}
