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
    public class FilmService : BaseCRUDService<Model.Film, Database.Film, BaseSearchObject, FilmInsertRequest, FilmInsertRequest>, IFilmService
    {
        public FilmService(eCinemaContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IQueryable<eCinema.Services.Database.Film> AddFilter(IQueryable<eCinema.Services.Database.Film> query, BaseSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Text))
                filteredQuery = filteredQuery.Where(x => x.Naziv.ToLower().Contains(search.Text.ToLower()));
          
            return filteredQuery;
        }

        public override Model.Film Delete(int id)
        {
            var entity = _context.Films.Find(id);
            var termini = _context.Termins.Where(e => e.FilmId == id).ToList();
            var filmGlumac = _context.FilmGlumacs.Where(e => e.FilmId == id).ToList();

            if (termini != null && termini.Any())
            {
                return null;
            }
            else if (entity == null)
            {
                return null;
            }
            else if (filmGlumac != null && filmGlumac.Any())
            {

                foreach (var uloga in filmGlumac)
                {
                    _context.FilmGlumacs.Remove(uloga);
                }
                _context.Films.Remove(entity);
            }
            else
            {
                _context.Films.Remove(entity);
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Film>(entity);
        }

        public Model.Zarada ZaradaReport(int id)
        {
            var termini = _context.Termins.Where(e => e.FilmId == id).ToList();
            int brKarata = 0, cijena = 0, zarada = 0;
            foreach (var termin in termini)
            {
                var karte = _context.Karta.Where(e => e.TerminId == termin.TerminId && e.Aktivna == false).ToList();

                var brojac = karte.Count;
                brKarata += brojac;
                cijena = termin.CijenaKarte ?? 0;
                zarada += (brojac * cijena);
            }

            var report = new Zarada()
            {
                BrKarata = brKarata,
                BrTermina = termini.Count,
                UkupnaZarada = zarada
            };

            return report;
        }
    }
}
