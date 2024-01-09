using System;
using System.Collections.Generic;

namespace eCinema.Services.Database
{
    public partial class Glumac
    {
        public Glumac()
        {
            FilmGlumacs = new HashSet<FilmGlumac>();
        }

        public int GlumacId { get; set; }
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public string? ImePrezime { get; set; }

        public virtual ICollection<FilmGlumac> FilmGlumacs { get; set; }
       
    }
}
