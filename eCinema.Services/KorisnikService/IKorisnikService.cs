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
    public interface IKorisnikService : IBaseCRUDService<Model.Korisnik, BaseSearchObject, KorisnikInsertRequest, KorisnikUpdateRequest>
    {
        Model.Korisnik GetByUsername(string korisnickoIme);
    }
}
