using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Model
{
    public class Cinema
    {
        public int CinemaId { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public string Webstranica { get; set; }
        public string Email { get; set; }
        public string BrTelefona { get; set; }
        public string? Logo { get; set; }
        public bool Aktivan { get; set; }
    }
}
