using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Model.SearchObjects
{
    public class FilmGlumacSearchObject : BaseSearchObject
    {
        public int? GlumacId { get; set; }
        public int? FilmId { get; set; }
    }
}
