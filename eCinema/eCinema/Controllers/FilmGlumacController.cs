using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services;

namespace eCinema.Controllers
{
    public class FilmGlumacController : BaseCRUDController<Model.FilmGlumac, FilmGlumacSearchObject, FilmGlumacInsertRequest, FilmGlumacInsertRequest>
    {
        public IFilmGlumacService _service { get; set; }
        public FilmGlumacController(IFilmGlumacService service) : base(service)
        {
            _service = service;
        }
    }
}
