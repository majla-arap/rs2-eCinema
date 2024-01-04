using System;
using System.Collections.Generic;

namespace eCinema.Services.Database
{
    public partial class Kupovina
    {
        public int KupovinaId { get; set; }
        public int? Kolicina { get; set; }
        public int? Cijena { get; set; }
        public DateTime? DatumKupovine { get; set; }
        public int? KorisnikId { get; set; }

        public virtual Korisnik? Korisnik { get; set; }
    }
}
