using AutoMapper;
using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services.BaseService;
using eCinema.Services.Database;
using Microsoft.EntityFrameworkCore;

namespace eCinema.Services
{
    public class KartaService : BaseCRUDService<Model.Karta, Database.Kartum, KartaSearchObject, KartaInsertRequest, KartaInsertRequest>, IKartaService
    {

        public KartaService(eCinemaContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IQueryable<eCinema.Services.Database.Kartum> AddInclude(IQueryable<eCinema.Services.Database.Kartum> query, KartaSearchObject search = null)
        {
            query = query.Include(x => x.Termin).Include(x=>x.Termin.Dvorana).Include(x=>x.Termin.Dvorana.Cinema).Include(x=>x.Termin.Film).Include(x => x.Kupovina);
            return base.AddInclude(query, search);
        }

        public override IQueryable<eCinema.Services.Database.Kartum> AddFilter(IQueryable<eCinema.Services.Database.Kartum> query, KartaSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Text))
                filteredQuery = filteredQuery.Where(x => x.Sjediste.Contains(search.Text));
            if (search.TerminId != null)
                filteredQuery = filteredQuery.Where(x => x.TerminId == search.TerminId);
            if (search.Aktivan != null)
                filteredQuery = filteredQuery.Where(x => x.Aktivna == search.Aktivan);
            return filteredQuery;
        }

        public override Model.Karta Delete(int id)
        {
            var entity = _context.Karta.Find(id);

            if (entity == null)
            {
                return null;
            }
            else
            {
                _context.Karta.Remove(entity);
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Karta>(entity);
        }

        public IEnumerable<Model.Karta> GetByTerminId(int id)
        {
            var entity = _context.Karta.Include(x => x.Termin).Include(x => x.Termin.Film).Include(x => x.Termin.Dvorana).Include(x => x.Termin.Dvorana.Cinema).Include(x => x.Kupovina).Where(x=>x.TerminId == id).AsQueryable();
            var list = entity.ToList();
            return _mapper.Map<IList<Model.Karta>>(list);
        }

    }
}
