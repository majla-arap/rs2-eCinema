using System;
using System.Collections.Generic;

namespace eCinema.Services.Database
{
    public partial class Dvorana
    {
        public Dvorana()
        {
            Termins = new HashSet<Termin>();
        }

        public int DvoranaId { get; set; }
        public string? Naziv { get; set; }
        public int? BrSjedista { get; set; }
        public int? BrRedova { get; set; }
        public int? BrSjedistaPoRedu { get; set; }
        public int? CinemaId { get; set; }

        public virtual Cinema? Cinema { get; set; }
        public virtual ICollection<Termin> Termins { get; set; }
    }
}
