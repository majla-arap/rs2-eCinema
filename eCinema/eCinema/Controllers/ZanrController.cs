using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services;

namespace eCinema.Controllers
{
    public class ZanrController : BaseCRUDController<Model.Zanr, BaseSearchObject, ZanrInsertRequest, ZanrInsertRequest>
    {
        public IZanrService _service { get; set; }
        public ZanrController(IZanrService service) : base(service)
        {
            _service = service;
        }
    }
}
