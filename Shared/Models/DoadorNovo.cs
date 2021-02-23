using System;

namespace Somar.Shared.Models
{
    public class DoadorNovo : Pessoa
    {
        public string DDD { get; set; }
        public string UltimaAcao { get; set; }
        public DateTime DtRetorno { get; set; }
        public DateTime? DtLigacao { get; set; }
    }
}
