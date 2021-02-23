namespace Somar.Shared.Models.Discadora
{
    public class TelephonyRate
    {
        public int Id { get; set; }
        public int Minimum_Duration { get; set; }
        public int Minimum_Duration_Charged { get; set; }
        public int Cadence { get; set; }
        public int Type { get; set; }
        public int Value { get; set; }
    }
}
