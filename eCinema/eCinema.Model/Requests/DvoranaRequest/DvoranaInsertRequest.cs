using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Model.Requests
{
    public class DvoranaInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }

        [Required]
        public int BrRedova { get; set; }

        [Required]
        public int BrSjedistaPoRedu { get; set; }

        [Required]
        public int CinemaId { get; set; }
    }
}
