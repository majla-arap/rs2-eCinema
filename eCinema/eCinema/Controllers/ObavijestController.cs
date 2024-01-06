using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services;

namespace eCinema.Controllers
{
    public class ObavijestController : BaseCRUDController<Model.Obavijest, ObavijestSearchObject, ObavijestInsertRequest, ObavijestUpdateRequest>
    {
        public IObavijestService _service { get; set; }
        public ObavijestController(IObavijestService service) : base(service)
        {
            _service = service;
        }
    }
}
