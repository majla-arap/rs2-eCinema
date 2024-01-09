using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services;

namespace eCinema.Controllers
{
    public class GlumacController : BaseCRUDController <Model.Glumac, BaseSearchObject, GlumacInsertRequest, GlumacInsertRequest>
    {
        public IGlumacService _service { get; set; }
        public GlumacController(IGlumacService service) : base(service)
        {
            _service = service;
        }
    }
}
