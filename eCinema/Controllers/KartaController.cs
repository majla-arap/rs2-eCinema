using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eCinema.Controllers
{
    public class KartaController : BaseCRUDController<Model.Karta, KartaSearchObject, KartaInsertRequest, KartaInsertRequest>
    {
        public IKartaService _service { get; set; }
        public KartaController(IKartaService service) : base(service)
        {
            _service = service;
        }

        [Authorize]
        [HttpGet("getByTerminId/{id}")]
        public IEnumerable<Model.Karta> GetByTerminId(int id)
        {
            return _service.GetByTerminId(id);
        }
    }
}
