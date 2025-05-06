using System.Collections.Generic;

namespace Sala.Database.Entities
{
	public class SportsHall : BaseEntity
	{
		public string Name { get; set; }
		public string Location { get; set; }

		public ICollection<Reservation> Reservations { get; set; }
	}
}
