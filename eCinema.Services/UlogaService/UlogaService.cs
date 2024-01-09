using AutoMapper;
using eCinema.Model.SearchObjects;
using eCinema.Services.BaseService;
using eCinema.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Services
{
    public class UlogaService : BaseService <Model.Uloga, Database.Uloga, BaseSearchObject>, IUlogaService
    {
        public UlogaService(eCinemaContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
