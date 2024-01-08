using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services.BaseService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Services
{
    public interface ITerminService : IBaseCRUDService<Model.Termin, TerminSearchObject, TerminInsertRequest, TerminInsertRequest>
    {
             public void ObrisiKarte(int id);
    }
}
