using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IBaseService<T, TC, TS>
        where T : class
        where TC : class
        where TS : class
    {
        DbSet<T> dbSet { get; }
        IMapper mapper { get; }

        public List<TS> GetAll();
        public TS GetById(object id);
        public void Create(TC data);
        public void Update(TC data);
        public void DeleteById(object id);
    }
}
