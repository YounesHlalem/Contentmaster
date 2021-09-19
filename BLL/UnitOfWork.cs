using AutoMapper;
using DAL.Context;
using DAL.Repository;
using System;

namespace BLL
{
    public class UnitOfWork : IDisposable
    {
        private E4ProgressContext context;
        private IMapper mapper;

        public UnitOfWork(IMapper mapper, E4ProgressContext context)
        {
            this.context = context;
            this.mapper = mapper;
        }

        private CourseRepository courseRepository;

        public CourseRepository CourseRepository => this.CourseRepository ?? new CourseRepository(mapper, context);

        #region Disposing
        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    // Dispose all contextes
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
