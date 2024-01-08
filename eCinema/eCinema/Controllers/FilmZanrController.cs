using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eCinema.Controllers
{
    public class FilmZanrController : BaseCRUDController<Model.FilmZanr, FilmZanrSearchObject, FilmZanrInsertRequest, FilmZanrInsertRequest>
    {
    
        public IFilmZanrService _service { get; set; }
        public FilmZanrController(IFilmZanrService service) : base(service)
        {
            _service = service;
        }
    }
}
