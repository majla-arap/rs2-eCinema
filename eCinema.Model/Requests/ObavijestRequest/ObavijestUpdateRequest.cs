﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Model.Requests
{
    public class ObavijestUpdateRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Naslov { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Podnaslov { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Sadrzaj { get; set; }

        [Required]
        public string Slika { get; set; }

        [Required]
        public int ObavijestKategorijaId { get; set; }

        [Required]
        public int KorisnikId { get; set; }
    }
}
