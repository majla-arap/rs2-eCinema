using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services;

namespace eCinema.Controllers
{

    public class DvoranaController : BaseCRUDController <Model.Dvorana, DvoranaSearchObject, DvoranaInsertRequest, DvoranaUpdateRequest>
    {
        public IDvoranaService _service { get; set; }
        public DvoranaController(IDvoranaService service) : base(service)
        {
            _service = service;
        }
    }
}
