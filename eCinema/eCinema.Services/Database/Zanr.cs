using System;
using System.Collections.Generic;

namespace eCinema.Services.Database
{
    public partial class Zanr
    {
        public Zanr()
        {
            FilmZanrs = new HashSet<FilmZanr>();
        }

        public int ZanrId { get; set; }
        public string? Naziv { get; set; }

        public virtual ICollection<FilmZanr> FilmZanrs { get; set; }
    }
}
