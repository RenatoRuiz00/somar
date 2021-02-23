using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Somar.Shared.Models.Discadora
{
    public class Route
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EndPoint { get; set; }
        public string route { get; set; }
        public string Uses_Country_Code { get; set; }
        public bool Allow_Mobile { get; set; }
        public bool Allow_Landline { get; set; }
        public List<TelephonyRate> Telephony_Rates { get; set; }
    }

}
