using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Model
{
    public class Termin
    {
        public int TerminId { get; set; }
        public bool Premijera { get; set; }
        public bool Predpremijera { get; set; }
        public int CijenaKarte { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public string VrijemeOdrzavanja { get; set; }

        public int? DvoranaId { get; set; }
        public virtual Dvorana? Dvorana { get; set; }
        public int? FilmId { get; set; }
        public virtual Film? Film { get; set; }
        
    }
}
