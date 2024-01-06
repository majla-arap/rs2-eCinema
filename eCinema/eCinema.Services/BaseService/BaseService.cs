using AutoMapper;
using eCinema.Model.SearchObjects;
using eCinema.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCinema.Services.BaseService
{
    public class BaseService <T, TDb, TSearch> : IBaseService<T, TSearch> where T : class where TDb : class where TSearch : BaseSearchObject
    {
        public eCinemaContext _context { get; set; }
        public IMapper _mapper { get; set; }
        public BaseService(eCinemaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual IEnumerable<T> GetAll(TSearch search = null)
        {
            var entity = _context.Set<TDb>().AsQueryable();
            entity = AddFilter(entity, search);
            entity = AddInclude(entity, search);
            var list = entity.ToList();
            return _mapper.Map<IList<T>>(list);
        }

        public virtual IQueryable<TDb> AddInclude(IQueryable<TDb> query, TSearch search = null)
        {
            return query;
        }

        public virtual IQueryable<TDb> AddFilter(IQueryable<TDb> query, TSearch search = null)
        {
            return query;
        }

        public virtual T GetById(int id)
        {
            var set = _context.Set<TDb>();

            var entity = set.Find(id);

            return _mapper.Map<T>(entity);
        }
    }
}
