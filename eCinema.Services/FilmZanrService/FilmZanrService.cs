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
    public class FilmZanrService : BaseCRUDService<Model.FilmZanr, Database.FilmZanr, FilmZanrSearchObject, FilmZanrInsertRequest, FilmZanrInsertRequest>, IFilmZanrService
    {
        public FilmZanrService(eCinemaContext context, IMapper mapper) : base(context, mapper)
        {

        }
        public override IQueryable<eCinema.Services.Database.FilmZanr> AddInclude(IQueryable<eCinema.Services.Database.FilmZanr> query, FilmZanrSearchObject search = null)
        {
            query = query.Include(x => x.Film).Include(x => x.Zanr);
            return base.AddInclude(query, search);
        }

        public override IQueryable<eCinema.Services.Database.FilmZanr> AddFilter(IQueryable<eCinema.Services.Database.FilmZanr> query, FilmZanrSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Text))
                filteredQuery = filteredQuery.Where(x => x.Film.Naziv.ToLower().Contains(search.Text.ToLower()));
            if (search.FilmId != null)
                filteredQuery = filteredQuery.Where(x => x.FilmId == search.FilmId);
            if (search.ZanrId != null)
                filteredQuery = filteredQuery.Where(x => x.ZanrId == search.ZanrId);
            return filteredQuery;
        }

        public override Model.FilmZanr Delete(int id)
        {
            var entity = _context.FilmZanrs.Find(id);
            var zanrs = _context.FilmZanrs.Where(e => e.FilmId == entity!.FilmId).ToList();

            if (entity == null)
            {
                return null;
            }
            else if (zanrs.Count() == 1)
            {
                throw new KorisnikException("Upozorenje", "Ne mozete obrisati zanr, Film mora imati bar jedan zanr");
            }
            else
            {
                _context.FilmZanrs.Remove(entity);
            }

            _context.SaveChanges();
            return _mapper.Map<Model.FilmZanr>(entity);
        }

        
    }
}
