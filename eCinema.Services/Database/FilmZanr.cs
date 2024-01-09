using System;
using System.Collections.Generic;

namespace eCinema.Services.Database
{
    public partial class FilmZanr
    {
        public int FilmZanrId { get; set; }
        public int? ZanrId { get; set; }
        public int? FilmId { get; set; }

        public virtual Film? Film { get; set; }
        public virtual Zanr? Zanr { get; set; }
    }
}
