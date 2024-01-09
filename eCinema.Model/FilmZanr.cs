using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Model
{
    public class FilmZanr
    {
        public int FilmZanrId { get; set; }
        public int? ZanrId { get; set; }
        public int? FilmId { get; set; }

        public virtual Film? Film { get; set; }
        public virtual Zanr? Zanr { get; set; }
    }
}
