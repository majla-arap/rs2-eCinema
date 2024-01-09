using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Model
{
    public class Dvorana
    {
        public int DvoranaId { get; set; }
        public string Naziv { get; set; }
        public int BrSjedista { get; set; }
        public int BrRedova { get; set; }
        public int BrSjedistaPoRedu { get; set; }

        public int? CinemaId { get; set; }
        public virtual Cinema? Cinema { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
