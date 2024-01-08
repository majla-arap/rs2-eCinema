using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Model.Requests
{
    public class FilmZanrInsertRequest
    {
        [Required]
        public int FilmId { get; set; }

        [Required]
        public int ZanrId { get; set; }
    }
}
