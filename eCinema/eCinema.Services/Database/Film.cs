using System;
using System.Collections.Generic;

namespace eCinema.Services.Database
{
    public partial class Film
    {
        public Film()
        {
            FilmGlumacs = new HashSet<FilmGlumac>();
            FilmZanrs = new HashSet<FilmZanr>();
            Termins = new HashSet<Termin>();
        }

        public int FilmId { get; set; }
        public string? Naziv { get; set; }
        public string? Sadrzaj { get; set; }
        public string? Slika { get; set; }
        public int? VrijemeTrajanje { get; set; }
        public string? Redatelj { get; set; }
        public string? Godina { get; set; }
        public DateTime? PocetakPrikazivanja { get; set; }

        public virtual ICollection<FilmGlumac> FilmGlumacs { get; set; }
        public virtual ICollection<FilmZanr> FilmZanrs { get; set; }
        public virtual ICollection<Termin> Termins { get; set; }
    }
}
