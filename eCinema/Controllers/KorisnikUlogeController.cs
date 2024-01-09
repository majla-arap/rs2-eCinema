using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services;

namespace eCinema.Controllers
{
    public class KorisnikUlogeController : BaseCRUDController<Model.KorisnikUloge, KorisnikUlogeSearchObject, KorisnikUlogeInsertRequest, KorisnikUlogeInsertRequest>
    {
        public IKorisnikUlogeService _service { get; set; }
        public KorisnikUlogeController(IKorisnikUlogeService service) : base(service)
        {
            _service = service;
        }
    }
}
