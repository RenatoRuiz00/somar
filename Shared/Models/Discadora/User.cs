namespace Somar.Shared.Models.Discadora
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Active { get; set; }
        public string Api_Token { get; set; }
        public int Confirmed { get; set; }
        public string Confirmation_Code { get; set; }
        public string Extension_Password { get; set; }
        public string Telephony_Id { get; set; }
        public Extension Extension { get; set; }
        public Role Role { get; set; }
        public UserSettings Settings { get; set; }
    }
}
