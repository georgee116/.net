namespace Sala.Core.Logic
{
    public static class SportsHallExtensions
    {
        public static string FormatName(this string name)
        {
            return name.Trim().ToUpperInvariant();
        }
    }
}
