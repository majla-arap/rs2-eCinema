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
    public class DvoranaService : BaseCRUDService <Model.Dvorana, Database.Dvorana, DvoranaSearchObject, DvoranaInsertRequest, DvoranaUpdateRequest>, IDvoranaService
    {
        public DvoranaService(eCinemaContext context, IMapper mapper) : base(context, mapper)
        {

        }
        public override IQueryable<eCinema.Services.Database.Dvorana> AddInclude(IQueryable<eCinema.Services.Database.Dvorana> query, DvoranaSearchObject search = null)
        {
            query = query.Include(x => x.Cinema);
            return base.AddInclude(query, search);
        }

        public override IQueryable<eCinema.Services.Database.Dvorana> AddFilter(IQueryable<eCinema.Services.Database.Dvorana> query, DvoranaSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Text))
                filteredQuery = filteredQuery.Where(x => x.Naziv.ToLower().Contains(search.Text.ToLower()));
            if (search.CinemaId != null)
                filteredQuery = filteredQuery.Where(x => x.CinemaId == search.CinemaId);
            return filteredQuery;
        }

        public override Model.Dvorana Insert(DvoranaInsertRequest request)
        {
            Database.Dvorana dvorana = new Database.Dvorana();
            dvorana.Naziv = request.Naziv;
            dvorana.BrRedova = request.BrRedova;
            dvorana.BrSjedistaPoRedu = request.BrSjedistaPoRedu;
            dvorana.CinemaId = request.CinemaId;
            dvorana.BrSjedista = request.BrRedova * request.BrSjedistaPoRedu;
            _context.Add(dvorana);
            _context.SaveChanges();
            return _mapper.Map<Model.Dvorana>(dvorana);
        }

        public override Model.Dvorana Delete(int id)
        {
            var entity = _context.Dvoranas.Find(id);
            var termini = _context.Termins.Where(e => e.DvoranaId == id).ToList();

            if (termini != null && termini.Any())
            {
                return null;
            }
            else if (entity == null)
            {
                return null;
            }
            else
            {
                _context.Dvoranas.Remove(entity);
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Dvorana>(entity);
        }
    }
}
