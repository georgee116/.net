using Microsoft.EntityFrameworkCore;
using Sala.Database.Context;
using Sala.Database.Entities;

namespace Sala.Database.Repositories;

public class SportsHallRepository : BaseRepository<SportsHall>
{
    public SportsHallRepository(SalaDatabaseContext context) : base(context) { }

    public async Task<List<SportsHall>> GetWithReservationsAsync()
    {
        return await _dbSet.Include(s => s.Reservations).ToListAsync();
    }

    public async Task<SportsHall?> GetByNameAsync(string name)
    {
        return await _dbSet.FirstOrDefaultAsync(s => s.Name == name);
    }
}
