namespace Somar.Shared.Models.Discadora
{
    public class Campaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Start_Time { get; set; }
        public string End_Time { get; set; }
        public bool Paused { get; set; }
        public int Acw_Timeout { get; set; }
        public bool Is_On_Active_Time { get; set; }
        public string Caller_Id { get; set; }
        public float Asr { get; set; }
        public bool Amd_Enable { get; set; }
        public Company Company { get; set; }
        public Extension Extension { get; set; }
        public DialerSettings DialerSettings { get; set; }
        public Route Route_Landline { get; set; }
        public Route Route_Mobile { get; set; }
        public WorkBreakGroup WorkBreakGroup { get; set; }
        public float Limit_Call_Per_Agent { get; set; }
       
    }
}
