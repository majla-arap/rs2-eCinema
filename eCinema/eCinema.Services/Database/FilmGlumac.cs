using System;
using System.Collections.Generic;

namespace eCinema.Services.Database
{
    public partial class FilmGlumac
    {
        public int FilmGlumacId { get; set; }
        public int? GlumacId { get; set; }
        public int? FilmId { get; set; }
        public string? NazivUloge { get; set; }

        public virtual Film? Film { get; set; }
        public virtual Glumac? Glumac { get; set; }
    }
}
