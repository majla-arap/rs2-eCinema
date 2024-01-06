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
    public class ObavijestKategorijaService : BaseCRUDService<Model.ObavijestKategorija, Database.ObavijestKategorija, BaseSearchObject, ObavijestKategorijaInsertRequest, ObavijestKategorijaInsertRequest>, IObavijestKategorijaService
    {
        public ObavijestKategorijaService(eCinemaContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override IQueryable<eCinema.Services.Database.ObavijestKategorija> AddFilter(IQueryable<eCinema.Services.Database.ObavijestKategorija> query, BaseSearchObject search = null)
        {
            var filteredQuery = base.AddFilter(query, search);

            if (!string.IsNullOrWhiteSpace(search?.Text))
                filteredQuery = filteredQuery.Where(x => x.Naziv.ToLower().Contains(search.Text.ToLower()));
            return filteredQuery;
        }

        public override Model.ObavijestKategorija Delete(int id)
        {
            var entity = _context.ObavijestKategorijas.Find(id);
            var obavijesti = _context.Obavijests.Where(e => e.ObavijestKategorijaId == id).ToList();

            if (obavijesti != null && obavijesti.Any())
            {
                return null;
            }
            else if (entity == null)
            {
                return null;
            }
            else
            {
                _context.ObavijestKategorijas.Remove(entity);
            }

            _context.SaveChanges();
            return _mapper.Map<Model.ObavijestKategorija>(entity);
        }
    }
}
