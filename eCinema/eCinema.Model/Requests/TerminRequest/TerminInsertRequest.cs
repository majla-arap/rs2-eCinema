﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Model.Requests
{
    public class TerminInsertRequest
    {
        [Required]
        public bool Premijera { get; set; }

        [Required]
        public bool Predpremijera { get; set; }

        [Required]
        public int CijenaKarte { get; set; }

        [Required]
        public DateTime DatumOdrzavanja { get; set; }

        [Required]
        public string VrijemeOdrzavanja { get; set; }

        public int? DvoranaId { get; set; }
        public int? FilmId { get; set; }
    }
}
