using AutoMapper;
using eCinema.Model.Requests;
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
    public class GlumacService : BaseCRUDService<Model.Glumac, Database.Glumac, BaseSearchObject, GlumacInsertRequest, GlumacInsertRequest>, IGlumacService
    {
        public GlumacService(eCinemaContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IQueryable<eCinema.Services.Database.Glumac> AddFilter(IQueryable<eCinema.Services.Database.Glumac> query, BaseSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Text))
                filteredQuery = filteredQuery.Where(x => x.ImePrezime.ToLower().Contains(search.Text.ToLower()));
            return filteredQuery;
        }

        public override Model.Glumac Delete(int id)
        {
            var entity = _context.Glumacs.Find(id);
            var glumciFilma = _context.FilmGlumacs.Where(e => e.GlumacId == id).ToList();

            if (glumciFilma != null && glumciFilma.Any())
            {
                return null;
            }
            else if (entity == null)
            {
                return null;
            }
            else
            {
                _context.Glumacs.Remove(entity);
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Glumac>(entity);
        }
    }
}
