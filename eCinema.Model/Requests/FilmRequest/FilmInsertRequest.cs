using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Model.Requests
{
    public class FilmInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Sadrzaj { get; set; }

        [Required]
        public string Slika { get; set; }

        [Required]
        public int VrijemeTrajanje { get; set; }

        [Required]
        public string Redatelj { get; set; }

        [Required]
        public string Godina { get; set; }
        
        [Required]
        public DateTime PocetakPrikazivanja { get; set; }

        [Required]
        public int ZanrId { get; set; }
    }
}
