using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Model.SearchObjects
{
    public class KartaSearchObject : BaseSearchObject
    {
        public bool? Aktivan { get; set; }   
        public int? TerminId { get; set; }
    }
}
