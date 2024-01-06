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
    public class ObavijestService : BaseCRUDService<Model.Obavijest, Database.Obavijest, ObavijestSearchObject, ObavijestInsertRequest, ObavijestUpdateRequest>, IObavijestService
    {
        public ObavijestService(eCinemaContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IQueryable<eCinema.Services.Database.Obavijest> AddInclude(IQueryable<eCinema.Services.Database.Obavijest> query, ObavijestSearchObject search = null)
        {
            query = query.Include(x => x.ObavijestKategorija).Include(x => x.Korisnik);
            return base.AddInclude(query, search);
        }

        public override IQueryable<eCinema.Services.Database.Obavijest> AddFilter(IQueryable<eCinema.Services.Database.Obavijest> query, ObavijestSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Text))
                filteredQuery = filteredQuery.Where(x => x.Naslov.ToLower().Contains(search.Text.ToLower()));
            if (search.ObavijestKategorijaId != null)
                filteredQuery = filteredQuery.Where(x => x.ObavijestKategorijaId == search.ObavijestKategorijaId);
            return filteredQuery;
        }
    }
}
