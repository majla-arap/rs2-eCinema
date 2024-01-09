using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Model
{
    public class DvoranaException : Exception
    {
        public string Title { get; set; }

        public DvoranaException(string title, string message) : base(message)
        {
            Title = title;
        }
    }
}
