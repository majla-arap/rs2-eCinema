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
    public interface IFilmZanrService : IBaseCRUDService<Model.FilmZanr, FilmZanrSearchObject, FilmZanrInsertRequest, FilmZanrInsertRequest>
    {
        // Model.Zarada ZaradaReport(int id);
    }
}
