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
    public class CinemaService : BaseCRUDService <Model.Cinema, Database.Cinema, BaseSearchObject, CinemaInsertRequest, CinemaInsertRequest>, ICinemaService
    {
        public CinemaService(eCinemaContext context, IMapper mapper) : base(context, mapper)
        {

        }

        //public override IQueryable<eCinema.Services.Database.Cinema> AddInclude(IQueryable<eCinema.Services.Database.Cinema> query, BaseSearchObject search = null)
        //{
        //    query = query.Include(x => x.Naziv);
        //    return base.AddInclude(query, search);
        //}

        public override IQueryable<eCinema.Services.Database.Cinema> AddFilter(IQueryable<eCinema.Services.Database.Cinema> query, BaseSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Text))
                filteredQuery = filteredQuery.Where(x => x.Naziv.ToLower().Contains(search.Text.ToLower()));
            if (search.Text != null)
                filteredQuery = filteredQuery.Where(x => x.Naziv == search.Text);
            return filteredQuery;
        }
       
        public override Model.Cinema Delete(int id)
        {
            var entity = _context.Cinemas.Find(id);
            var dvo = _context.Dvoranas.Where(e => e.CinemaId == id).ToList();

            if (dvo != null && dvo.Any())
            {
                return null;
            }
            else if (entity == null)
            {
                return null;
            }
            else
            {
                _context.Cinemas.Remove(entity);
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Cinema>(entity);
        }
    }
}
