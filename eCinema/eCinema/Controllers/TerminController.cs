using eCinema.Model;
using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services;
using eCinema.Services.BaseService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace eCinema.Controllers
{
    public class TerminController : BaseCRUDController<Model.Termin, TerminSearchObject, TerminInsertRequest, TerminInsertRequest>
    {
        public ITerminService _service { get; set; }
        public TerminController (ITerminService service) : base(service)
        {
            _service = service;
        }

        [Authorize(Roles = "Admin")]
        public override Model.Termin Insert([FromBody] TerminInsertRequest request)
        {
            return base.Insert(request);
        }

        [Authorize(Roles = "Admin")]
        public override Model.Termin Update(int id, [FromBody] TerminInsertRequest request)
        {
            return base.Update(id, request);
        }

      
      

        [Authorize]
        [HttpGet("obrisiKarte/{id}")]
        public void ObrisiKarte(int id)
        {
            _service.ObrisiKarte(id);
        }
    }
}
