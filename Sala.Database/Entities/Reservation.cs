using Sala.Database.Entities;

public class Reservation : BaseEntity
{
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }

    public int SportsHallId { get; set; }
    public SportsHall? SportsHall { get; set; }
}
