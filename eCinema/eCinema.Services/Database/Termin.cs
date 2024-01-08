using System;
using System.Collections.Generic;

namespace eCinema.Services.Database
{
    public partial class Termin
    {       

        public Termin()
        {
            Karta = new HashSet<Kartum>();
        }

        public int TerminId { get; set; }
        public int? DvoranaId { get; set; }
        public int? FilmId { get; set; }
        public bool? Premijera { get; set; }
        public bool? Predpremijera { get; set; }
        public int? CijenaKarte { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public string? VrijemeOdrzavanja { get; set; }

        public virtual Dvorana? Dvorana { get; set; }
        public virtual Film? Film { get; set; }
        public virtual ICollection<Kartum> Karta { get; set; }
    }
}
