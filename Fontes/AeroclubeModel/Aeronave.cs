using System;
using System.Collections.Generic;

namespace Aeroclube
{
    public partial class Aeronave
    {
        public Aeronave()
        {
            AeronaveAgendaReserva = new HashSet<AeronaveAgendaReserva>();
            AeronaveArquivo = new HashSet<AeronaveArquivo>();
            AeronaveDocumento = new HashSet<AeronaveDocumento>();
        }

        public int CdAeronave { get; set; }
        public string NrAeronave { get; set; }
        public string DsAeronave { get; set; }
        public int CdTipoAeronave { get; set; }

        public virtual ICollection<AeronaveAgendaReserva> AeronaveAgendaReserva { get; set; }
        public virtual ICollection<AeronaveArquivo> AeronaveArquivo { get; set; }
        public virtual ICollection<AeronaveDocumento> AeronaveDocumento { get; set; }
        public virtual TipoAeronave CdTipoAeronaveNavigation { get; set; }
    }
}
