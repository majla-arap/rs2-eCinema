using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eCinema.Controllers
{
    public class FilmController : BaseCRUDController<Model.Film, BaseSearchObject, FilmInsertRequest, FilmInsertRequest>
    {
        public IFilmService _service { get; set; }
        public FilmController(IFilmService service) : base(service)
        {
            _service = service;
        }

        [Authorize]
        [HttpGet("zaradaReport/{id}")]
        public Model.Zarada ZaradaReport(int id)
        {
            return _service.ZaradaReport(id);
        }
    }
}
