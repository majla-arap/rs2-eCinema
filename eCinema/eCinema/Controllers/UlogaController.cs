using eCinema.Model.SearchObjects;
using eCinema.Services;

namespace eCinema.Controllers
{
    public class UlogaController : BaseController<Model.Uloga, BaseSearchObject>
    {
        public UlogaController(IUlogaService service) : base(service)
        {

        }
    }
}
