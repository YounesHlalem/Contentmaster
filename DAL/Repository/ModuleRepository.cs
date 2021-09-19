using AutoMapper;
using DAL.Context;
using DAL.Model;

namespace DAL.Repository
{
    public class ModuleRepository : GenericRepository<E4ProgressContext, CourseModule>
    {

        public ModuleRepository(E4ProgressContext context, IMapper mapper) : base(mapper)
        {
            Context = context;
        }
    }
}
