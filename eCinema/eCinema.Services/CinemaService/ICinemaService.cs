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
    public interface ICinemaService : IBaseCRUDService <Model.Cinema, BaseSearchObject, CinemaInsertRequest, CinemaInsertRequest>
    {

    }
}
