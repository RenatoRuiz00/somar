using System.Collections.Generic;

namespace Somar.Shared.Models.Discadora
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        public float Balance { get; set; }
        public string Domain { get; set; }
        public string Logo_Name { get; set; }
        public string Logo_Image_Link { get; set; }
        public string Socket_Channel { get; set; }
        public int Active_Calls { get; set; }
        public List<User> Users { get; set; }
    }
}
