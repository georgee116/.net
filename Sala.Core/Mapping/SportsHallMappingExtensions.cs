using Sala.Core.Dtos.Responses.SportsHalls;
using Sala.Database.Entities;

namespace Sala.Core.Mapping
{
    public static class SportsHallMappingExtensions
    {
        public static GetSportsHallResponse ToResponse(this SportsHall hall)
        {
            return new GetSportsHallResponse
            {
                Id = hall.Id,
                Name = hall.Name,
                Location = hall.Location
            };
        }
    }
}
