﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Model.Requests
{
    public class CinemaInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Adresa { get; set; }

        [Required(AllowEmptyStrings = false)]
        [RegularExpression("^(https?:\\/\\/)?([\\da-z\\.-]+)\\.([a-z\\.]{2,6})([\\/\\w \\.-]*)*\\/?$")]
        public string Webstranica { get; set; }

        [Required(AllowEmptyStrings = false)]
        [EmailAddress()]
        public string Email { get; set; }

        [RegularExpression("^\\d{3}-\\d{3}-(\\d{4}|\\d{3})$")]
        [Required]
        public string BrTelefona { get; set; }

        public string? Logo { get; set; }

        [Required]
        public bool Aktivan { get; set; }
    }
}
