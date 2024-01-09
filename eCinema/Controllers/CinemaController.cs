using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services;

namespace eCinema.Controllers
{
    public class CinemaController : BaseCRUDController<Model.Cinema, BaseSearchObject, CinemaInsertRequest, CinemaInsertRequest>
    {
        public ICinemaService _service { get; set; }
        public CinemaController(ICinemaService service) : base(service)
        {
            _service = service;
        }
    }
}
