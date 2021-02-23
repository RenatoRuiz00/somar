namespace Somar.Shared.Models.Discadora
{
    public class UserSettings
    {
        public int Id { get; set; }
        public string Timezone { get; set; }
        public string Language { get; set; }
        public string Date_Format { get; set; }
        public string Hour_Format { get; set; }
        public bool Web_Extension { get; set; }
    }
}
