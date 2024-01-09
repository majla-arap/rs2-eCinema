using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Model.Requests
{
    public class FilmGlumacInsertRequest
    {
        [Required]
        public int GlumacId { get; set; }

        [Required]
        public int FilmId { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string NazivUloge { get; set; }
    }
}
