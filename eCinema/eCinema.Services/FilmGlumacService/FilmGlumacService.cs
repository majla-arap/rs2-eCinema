using AutoMapper;
using eCinema.Model;
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
    public class FilmGlumacService : BaseCRUDService<Model.FilmGlumac, Database.FilmGlumac, FilmGlumacSearchObject, FilmGlumacInsertRequest, FilmGlumacInsertRequest>, IFilmGlumacService
    {
        public FilmGlumacService(eCinemaContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IQueryable<eCinema.Services.Database.FilmGlumac> AddInclude(IQueryable<eCinema.Services.Database.FilmGlumac> query, FilmGlumacSearchObject search = null)
        {
            query = query.Include(x => x.Film).Include(x=>x.Glumac);
            return base.AddInclude(query, search);
        }

        public override IQueryable<eCinema.Services.Database.FilmGlumac> AddFilter(IQueryable<eCinema.Services.Database.FilmGlumac> query, FilmGlumacSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Text))
                filteredQuery = filteredQuery.Where(x => x.NazivUloge.ToLower().Contains(search.Text.ToLower()));
            if (search.FilmId != null)
                filteredQuery = filteredQuery.Where(x => x.FilmId == search.FilmId);
            if (search.GlumacId != null)
                filteredQuery = filteredQuery.Where(x => x.GlumacId == search.GlumacId);
            return filteredQuery;
        }

        public override Model.FilmGlumac Delete(int id)
        {
            var entity = _context.FilmGlumacs.Find(id);
            var glumci = _context.FilmGlumacs.Where(e => e.FilmId == entity!.FilmId).ToList();

            if (entity == null)
            {
                return null;
            }
            else if (glumci.Count() == 1)
            {
                throw new KorisnikException("Upozorenje","Ne mozete obrisati glumca, Film mora imati bar jednog glumca");
            }
            else
            {
                _context.FilmGlumacs.Remove(entity);
            }

            _context.SaveChanges();
            return _mapper.Map<Model.FilmGlumac>(entity);
        }
    }
}
