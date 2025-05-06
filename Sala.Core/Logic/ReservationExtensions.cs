using System;

namespace Sala.Core.Logic
{
    public static class ReservationExtensions
    {
        public static bool Overlaps(this DateTime start1, DateTime end1, DateTime start2, DateTime end2)
        {
            return start1 < end2 && start2 < end1;
        }
    }
}
