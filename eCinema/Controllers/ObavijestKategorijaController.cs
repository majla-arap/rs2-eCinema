using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services;

namespace eCinema.Controllers
{
    public class ObavijestKategorijaController : BaseCRUDController <Model.ObavijestKategorija, BaseSearchObject, ObavijestKategorijaInsertRequest, ObavijestKategorijaInsertRequest>
    {
        public IObavijestKategorijaService _service { get; set; }
        public ObavijestKategorijaController(IObavijestKategorijaService service) : base(service)
        {
            _service = service;
        }
    }
}
