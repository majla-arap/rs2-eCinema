using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Model
{
    public class Film
    {
        public int FilmId { get; set; }
        public string Naziv { get; set; }
        public string Sadrzaj { get; set; }
        public string? Slika { get; set; }
        public int VrijemeTrajanje { get; set; }
        public string Redatelj { get; set; }
        public string Godina { get; set; }
        public DateTime PocetakPrikazivanja { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
