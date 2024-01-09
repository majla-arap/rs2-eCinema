using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eCinema.Controllers
{
    public class KupovinaController : BaseCRUDController<Model.Kupovina, KupovinaSearchObject, KupovinaInsertRequest, KupovinaInsertRequest>
    {
        public IKupovinaService _service { get; set; }
        public IKartaService _kartaService { get; set; }

        public KupovinaController(IKupovinaService service, IKartaService kartaService) : base(service)
        {
            _service = service;
            _kartaService = kartaService;
        }
     
        [Authorize]
        [HttpGet("getByKorisnikId/{id}")]
        public IEnumerable<Model.Kupovina> GetByKorisnikId(int id)
        {
            return _service.GetByKorisnikId(id);
        }

        [Authorize]
        [HttpPatch()]
        public Model.Kupovina ChangeTicketStatus([FromBody] KartaChangeStatus request)
        {
            return _service.ChangeTicketStatus(request);
        }
    }
}
