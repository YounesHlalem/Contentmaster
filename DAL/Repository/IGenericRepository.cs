using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DAL
{
    public interface IGenericRepository<TM>
        where TM : class
    {
        List<TD> GetAll<TD>(bool mapReset = true) where TD : class;
        List<TD> FindBy<TD>(Expression<Func<TM, bool>> predicate, bool mapReset = true) where TD : class;
        void Add<TD>(TD entity) where TD : class;
        void Add(TM entity);
        int Add<TD>(TD entity, bool returnId, string returnName) where TD : class;
        void Delete(Expression<Func<TM, bool>> predicate);
        void Edit<TD>(TD entity, bool hasMap = false) where TD : class;
        void Save();
    }
}