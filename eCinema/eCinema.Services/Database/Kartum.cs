using System;
using System.Collections.Generic;

namespace eCinema.Services.Database
{
    public partial class Kartum
    {
        public int KartaId { get; set; }
        public bool? Aktivna { get; set; }
        public int? TerminId { get; set; }
        public string? Sjediste { get; set; }

        public virtual Termin? Termin { get; set; }
    }
}
