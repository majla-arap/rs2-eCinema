using AutoMapper;
using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services.BaseService;
using eCinema.Services.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Services
{
    public class KorisnikUlogeService : BaseCRUDService<Model.KorisnikUloge, Database.KorisnikUloge, KorisnikUlogeSearchObject, KorisnikUlogeInsertRequest, KorisnikUlogeInsertRequest>, IKorisnikUlogeService
    {
        public KorisnikUlogeService(eCinemaContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IQueryable<eCinema.Services.Database.KorisnikUloge> AddInclude(IQueryable<eCinema.Services.Database.KorisnikUloge> query,KorisnikUlogeSearchObject search = null)
        {
            query = query.Include(x => x.Uloga).Include(x => x.Korisnik);
            return base.AddInclude(query, search);
        }

        public override IQueryable<eCinema.Services.Database.KorisnikUloge> AddFilter(IQueryable<eCinema.Services.Database.KorisnikUloge> query, KorisnikUlogeSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search.KorisnikId != null)
                filteredQuery = filteredQuery.Where(x => x.KorisnikId == search.KorisnikId);
            if(search.UlogaId != null)
                filteredQuery = filteredQuery.Where(x=>x.UlogaId == search.UlogaId);
            return filteredQuery;
        }
    }
}
