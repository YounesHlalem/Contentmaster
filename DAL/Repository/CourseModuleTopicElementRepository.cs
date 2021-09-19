using AutoMapper;
using DAL.Context;
using DAL.Model;

namespace DAL.Repository
{
    public class CourseModuleTopicElementRepository : GenericRepository<E4ProgressContext, CourseModuleTopicElement>
    {
        public CourseModuleTopicElementRepository(E4ProgressContext context, IMapper mapper) : base(mapper)
        {
            Context = context;
        }
    }
}
