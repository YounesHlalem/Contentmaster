using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DAL
{
    public class GenericRepository<TC, TM> : IGenericRepository<TM>
        where TM : class
        where TC : DbContext, new()
    {
        private TC _entities = new TC();
        public TC Context
        {
            get { return _entities; }
            set { _entities = value; }
        }

        private IMapper Mapper;

        public GenericRepository(IMapper mapper)
        {
            this.Mapper = mapper;
        }

        public virtual List<TD> GetAll<TD>(bool mapReset = true) where TD : class
        {
            var ent = _entities.Set<TM>();
            var query = ent.ToList();

            var list = MapToDtoList<TM, TD>(query).ToList();
            return list;
        }

        public List<TD> FindBy<TD>(Expression<Func<TM, bool>> predicate, bool mapReset = true) where TD : class
        {
            var ent = _entities.Set<TM>();
            var query = ent.Where(predicate).ToList();

            var list = MapToDtoList<TM, TD>(query).ToList();
            return list;
        }

        public TD SingleOrDefault<TD>(Expression<Func<TM, bool>> predicate) where TD : class
        {
            var ent = _entities.Set<TM>();
            var query = ent.SingleOrDefault(predicate);

            if (query == null)
                return null;

            var item = Mapper.Map<TM, TD>(query);

            return item;
        }

        public bool Any(Expression<Func<TM, bool>> predicate)
        {
            var result = _entities.Set<TM>().Any(predicate);
            return result;
        }

        public virtual void Add<TD>(TD entity) where TD : class
        {
            var item = Mapper.Map<TD, TM>(entity);

            _entities.Set<TM>().Add(item);
            Save();
        }

        public virtual int Add<TD>(TD entity, bool returnId, string returnName) where TD : class
        {
            var item = Mapper.Map<TD, TM>(entity);

            _entities.Set<TM>().Add(item);
            Save();
            return returnId ? (int)item.GetType().GetProperty(returnName).GetValue(item, null) : 0;
        }

        public virtual void Add(TM entity)
        {
            _entities.Set<TM>().Add(entity);
            Save();
        }

        public virtual TM AddGetId<TD>(TD entity) where TD : class
        {
            var item = Mapper.Map<TD, TM>(entity);

            _entities.Set<TM>().Add(item);
            Save();
            return item;
        }

        public virtual void Delete(Expression<Func<TM, bool>> predicate)
        {
            _entities.Set<TM>().RemoveRange(_entities.Set<TM>().Where(predicate));
            Save();
        }

        public virtual void Edit<TD>(TD entity, bool hasMap = false) where TD : class
        {
            var participationDto = Mapper.Map<TD, TM>(entity);

            _entities.Set<TM>().Attach(participationDto);
            _entities.Entry(participationDto).State = EntityState.Modified;

            Save();
        }

        public virtual void Save()
        {
            _entities.SaveChanges();
        }

        public IQueryable<TM> List(Expression<Func<TM, bool>> filter = null, Func<IQueryable<TM>,
            IOrderedQueryable<TM>> orderBy = null, List<Expression<Func<TM, object>>> includeProperties = null,
        int? page = null, int? pageSize = null)
        {
            IQueryable<TM> query = _entities.Set<TM>();

            if (includeProperties != null)
                includeProperties.ForEach(i => { query = query.Include(i); });

            if (filter != null)
                query = query.Where(filter);

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (page != null && pageSize != null)
                query = query
                    .Skip(page.Value)
                    .Take(pageSize.Value);

            return query;
        }

        public IQueryable<TM> List(Expression<Func<TM, bool>> filter = null, string orderBy = null, string ascendingDescending = "ASC",
            List<Expression<Func<TM, object>>> includeProperties = null,
       int? page = null, int? pageSize = null)
        {
            IQueryable<TM> query = _entities.Set<TM>();

            if (includeProperties != null)
                includeProperties.ForEach(i => { query = query.Include(i); });

            if (filter != null)
                query = query.Where(filter);

            if (page != null && pageSize != null)
                query = query
                    .OrderBy(orderBy ?? "Id", ascendingDescending == "ASC")
                    .Skip(page.Value)
                    .Take(pageSize.Value);

            return query;
        }

        public Tuple<IQueryable<TM>, int> ListWithPaging(Expression<Func<TM, bool>> filter = null, Func<IQueryable<TM>,
            IOrderedQueryable<TM>> orderBy = null, List<Expression<Func<TM, object>>> includeProperties = null,
        int? page = null, int? pageSize = null)
        {
            IQueryable<TM> query = _entities.Set<TM>();

            if (includeProperties != null)
                includeProperties.ForEach(i => { query = query.Include(i); });

            if (filter != null)
                query = query.Where(filter);

            if (orderBy != null)
            {
                query = orderBy(query);
            }
            var count = query.Count();
            if (page != null && pageSize != null)
                query = query
                    .Skip(page.Value)
                    .Take(pageSize.Value);

            return new Tuple<IQueryable<TM>, int>(query, count);
        }

        public Tuple<IQueryable<TM>, int> ListWithPaging(Expression<Func<TM, bool>> filter = null, string orderBy = null, string ascendingDescending = "ASC",
           List<Expression<Func<TM, object>>> includeProperties = null,
      int? page = null, int? pageSize = null)
        {
            IQueryable<TM> query = _entities.Set<TM>();

            if (includeProperties != null)
                includeProperties.ForEach(i => { query = query.Include(i); });

            if (filter != null)
                query = query.Where(filter);

            var count = query.Count();

            if (page != null && pageSize != null)
                query = query
                    .OrderBy(orderBy ?? "Id", ascendingDescending == "ASC")
                    .Skip(page.Value)
                    .Take(pageSize.Value);

            return new Tuple<IQueryable<TM>, int>(query, count);
        }

        public IQueryable<TD> ToDtoListPaging<TD>(List<TD> list, string orderBy = null, string ascendingDescending = "ASC", int? page = null, int? pageSize = null) where TD : class
        {
            IQueryable<TD> query = list.AsQueryable();

            if (page != null && pageSize != null)
                query = query
                    .OrderBy(orderBy ?? "Id", ascendingDescending == "ASC")
                    .Skip(page.Value)
                    .Take(pageSize.Value);

            return query;
        }

        public virtual IEnumerable<TDto> MapToDtoList<TEntity, TDto>(IEnumerable<TEntity> entity)
            where TEntity : class
            where TDto : class
        {
            return Mapper.Map<IEnumerable<TEntity>, IEnumerable<TDto>>(entity);
        }

        public virtual IEnumerable<TEntity> MapToEntityList<TDto, TEntity>(IEnumerable<TDto> dto)
            where TDto : class
            where TEntity : class
        {
            return Mapper.Map<IEnumerable<TDto>, IEnumerable<TEntity>>(dto);
        }
    }
}
