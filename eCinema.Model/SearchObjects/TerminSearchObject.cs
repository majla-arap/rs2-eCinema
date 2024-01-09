using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Model.SearchObjects
{
    public class TerminSearchObject : BaseSearchObject
    {
        public bool? Premijera { get; set; }
        public bool? Predpremijera { get; set; }
        public int? DvoranaId { get; set; }
        public int? FilmId { get; set; }
        public DateTime? DatumOdrzavanja { get; set; }
        public string? VrijemeOdrzavanja { get; set; }
    }
}
