using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Model
{
    public class FilmGlumac
    {
        public int FilmGlumacId { get; set; }
        public int? GlumacId { get; set; }
        public int? FilmId { get; set; }
        public string NazivUloge { get; set; }

        public virtual Glumac? Glumac { get; set; }
        public virtual Film? Film { get; set; }
    }
}
