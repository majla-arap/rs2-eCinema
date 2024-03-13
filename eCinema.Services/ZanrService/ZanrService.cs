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
    public class ZanrService : BaseCRUDService<Model.Zanr, Database.Zanr, BaseSearchObject, ZanrInsertRequest, ZanrInsertRequest>, IZanrService
    {
        public ZanrService(eCinemaContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IQueryable<eCinema.Services.Database.Zanr> AddFilter(IQueryable<eCinema.Services.Database.Zanr> query, BaseSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Text))
                filteredQuery = filteredQuery.Where(x => x.Naziv.ToLower().Contains(search.Text.ToLower()));
            return filteredQuery;
        }

        public override Model.Zanr Delete(int id)
        {
            var entity = _context.Zanrs.Find(id);
            var filmZanr = _context.FilmZanrs.Where(e => e.ZanrId == id).ToList();
            
            if (filmZanr != null && filmZanr.Any())
            {
                return null;
            }
            if (entity == null)
            {
                return null;
            }
            else
            {
                _context.Zanrs.Remove(entity);
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Zanr>(entity);
        }
    }
}
