using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Model.SearchObjects
{
    public class FilmZanrSearchObject : BaseSearchObject
    {

        public int? FilmId { get; set; }

        public int? ZanrId { get; set; }
    }
}
