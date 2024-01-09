using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Model.Requests
{
    public class ZanrInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }
    }
}
