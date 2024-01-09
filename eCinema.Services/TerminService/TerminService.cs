using AutoMapper;
using eCinema.Model;
using eCinema.Model.Requests;
using eCinema.Model.SearchObjects;
using eCinema.Services.BaseService;
using eCinema.Services.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Services
{
    public class TerminService : BaseCRUDService<Model.Termin, Database.Termin, TerminSearchObject, TerminInsertRequest, TerminInsertRequest>, ITerminService
    {
        IKartaService _kartaService { get; set; }

        public TerminService(eCinemaContext context, IMapper mapper, IKartaService kartaService) : base(context, mapper)
        {
            _kartaService = kartaService;
        }

        public override IQueryable<eCinema.Services.Database.Termin> AddInclude(IQueryable<eCinema.Services.Database.Termin> query, TerminSearchObject search = null)
        {
            query = query.Include(x => x.Film).Include(x=>x.Dvorana).Include(x => x.Dvorana.Cinema);
            return base.AddInclude(query, search);
        }

        public override IQueryable<eCinema.Services.Database.Termin> AddFilter(IQueryable<eCinema.Services.Database.Termin> query, TerminSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search.FilmId != null)
                filteredQuery = filteredQuery.Where(x => x.FilmId == search.FilmId);
            if (search.DvoranaId != null)
                filteredQuery = filteredQuery.Where(x => x.DvoranaId == search.DvoranaId);
            if (search.Premijera != null)
                filteredQuery = filteredQuery.Where(x => x.Premijera == search.Premijera);
            if (search.Predpremijera != null)
                filteredQuery = filteredQuery.Where(x => x.Predpremijera == search.Predpremijera);
            if (search.DatumOdrzavanja.HasValue)
                filteredQuery = filteredQuery.Where(x => x.DatumOdrzavanja.Date.Equals(search.DatumOdrzavanja.Value.Date));
            if (!string.IsNullOrWhiteSpace(search?.VrijemeOdrzavanja))
                filteredQuery = filteredQuery.Where(x => x.VrijemeOdrzavanja.ToLower().Equals(search.VrijemeOdrzavanja.ToLower()));
            return filteredQuery;
        }
        public override Model.Termin Insert(TerminInsertRequest request)
        {
            var predstava = _context.Films.First(x => x.FilmId == request.FilmId);
            if (predstava == null)
                throw new Exception("Film nije pronađena");
            var sala = _context.Dvoranas.First(x => x.DvoranaId == request.DvoranaId); 
            if (sala == null)
                throw new Exception("Sala nije pronađena");

            var termini = _context.Termins.Where(e => e.DatumOdrzavanja.Date == request.DatumOdrzavanja.Date && e.DvoranaId == request.DvoranaId && e.VrijemeOdrzavanja.ToLower().Equals(request.VrijemeOdrzavanja.ToLower())).ToList();
            if (termini.Any())
               throw new DvoranaException("Zauzeta Dvorana", "Dvorana je zauzeta u tom terminu!");
            else
            {

                var termin = base.Insert(request);
                if (termin != null)
                {
                    for (int i = 0; i < sala.BrRedova; i++)
                    {
                        var red = (char)(i + 65);
                        for (int j = 0; j < sala.BrSjedistaPoRedu; j++)
                        {
                            KartaInsertRequest kartaInsertRequest = new KartaInsertRequest
                            {
                                Aktivna = true,
                                TerminId = termin.TerminId,
                                BrojSjedista = j + 1,
                                BrojReda = red.ToString(),
                                Sjediste = $"{red.ToString()}{(j + 1).ToString()}"
                            };
                            var karta = _kartaService.Insert(kartaInsertRequest);
                        }
                    }
                }
                return termin;
            }
        }

        public override Model.Termin Update(int id, TerminInsertRequest request)
        {
            var termini = _context.Termins.Where(e => e.TerminId != id && e.DatumOdrzavanja.Date == request.DatumOdrzavanja.Date && e.DvoranaId == request.DvoranaId && e.VrijemeOdrzavanja.ToLower().Equals(request.VrijemeOdrzavanja.ToLower())).ToList();
            if (termini != null && termini.Count > 0)
                throw new DvoranaException("Zauzeta dvorana", "Dvorana je zauzeta u tom terminu!");
            return base.Update(id, request);
        }

        public override Model.Termin Delete(int id)
        {
            var entity = _context.Termins.Find(id);
            var karte = _context.Karta.Where(e => e.TerminId == id).ToList();

            if (karte != null && karte.Any())
            {
                return null;
            }
            else if (entity == null)
            {
                return null;
            }
            else
            {
                _context.Termins.Remove(entity);
            }

            _context.SaveChanges();
            return _mapper.Map<Model.Termin>(entity);
        }

        public void ObrisiKarte(int id)
        {
            var karte = _context.Karta.Where(e => e.TerminId == id).ToList();
            var brojac = karte.Where(e => e.Aktivna == false).Count();

            if (karte == null)
            {
                throw new DvoranaException("Ne mozete obrisati", "Ne postoje karte za ovaj termin!");
            }
            else if(brojac != 0)
            {
                throw new DvoranaException("Ne mozete obrisati", "Ne možete obrisati karte, jer su neke već kupljene!");
            }
            else
            {
                for (int i = 0; i < karte.Count; i++)
                {
                    _context.Karta.Remove(karte[i]);
                }
            }
            _context.SaveChanges();
        }
    }
}

