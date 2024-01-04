using System;
using System.Collections.Generic;

namespace eCinema.Services.Database
{
    public partial class Cinema
    {
        public Cinema()
        {
            Dvoranas = new HashSet<Dvorana>();
        }

        public int CinemaId { get; set; }
        public string? Naziv { get; set; }
        public string? Adresa { get; set; }
        public string? Webstranica { get; set; }
        public string? Email { get; set; }
        public string? BrTelefona { get; set; }
        public string? Logo { get; set; }
        public bool? Aktivan { get; set; }

        public virtual ICollection<Dvorana> Dvoranas { get; set; }
    }
}
