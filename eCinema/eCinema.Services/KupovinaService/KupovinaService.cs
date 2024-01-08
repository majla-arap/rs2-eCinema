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
    public class KupovinaService : BaseCRUDService<Model.Kupovina, Database.Kupovina, KupovinaSearchObject, KupovinaInsertRequest, KupovinaInsertRequest>, IKupovinaService
    {
        IKartaService _kartaService { get; set; }        
     

        public KupovinaService(eCinemaContext context, IMapper mapper, IKartaService kartaService) : base(context, mapper)
        {
            _kartaService = kartaService;
            
        }

        public override IQueryable<eCinema.Services.Database.Kupovina> AddInclude(IQueryable<eCinema.Services.Database.Kupovina> query, KupovinaSearchObject search = null)
        {
            query = query.Include(x => x.Korisnik).Include(x=>x.Termin).Include(x=>x.Termin.Film).Include(x => x.Termin.Dvorana).Include(x => x.Termin.Dvorana.Cinema);
            return base.AddInclude(query, search);
        }

        public override IQueryable<eCinema.Services.Database.Kupovina> AddFilter(IQueryable<eCinema.Services.Database.Kupovina> query, KupovinaSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (search.KorisnikId != null)
                filteredQuery = filteredQuery.Where(x => x.KorisnikId == search.KorisnikId);
            if (search.Placena != null)
                filteredQuery = filteredQuery.Where(x => x.Placena == search.Placena);
            return filteredQuery;
        }

       

        public IEnumerable<Model.Kupovina> GetByKorisnikId(int id)
        {
            var entity = _context.Kupovinas.Include(x => x.Termin).Include(x => x.Termin.Film).Include(x => x.Termin.Dvorana).Include(x => x.Termin.Dvorana.Cinema).Include(x => x.Korisnik).Where(x => x.KorisnikId == id).Where(x=>x.Placena == true).OrderByDescending(k=>k.DatumKupovine).AsQueryable();
            var list = entity.ToList();
            return _mapper.Map<IList<Model.Kupovina>>(list);
        }

        public Model.Kupovina ChangeTicketStatus(KartaChangeStatus kcs)
        {
            var karte = _context.Karta.Where(x=> kcs.ListaKarta.Contains(x.KartaId));
            var kupovina = _context.Kupovinas.Include(x=>x.Korisnik).Include(x=>x.Termin).ThenInclude(x=>x.Film).FirstOrDefault(x=> x.KupovinaId == kcs.KupovinaId);
            if (karte == null)
                return null;
            else
            {
                foreach(Kartum karta in karte)
                {
                    karta.Aktivna = false;
                    karta.KupovinaId = kcs.KupovinaId;
                }
                if (kupovina != null)
                    kupovina.Placena = true;
            }
            _context.SaveChanges();

          

            return _mapper.Map<Model.Kupovina>(kupovina);
        }
    }
}
