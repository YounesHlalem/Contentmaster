using AutoMapper;
using DAL.Context;
using DAL.Model;

namespace DAL.Repository
{
    public class CourseModuleTopicRepository : GenericRepository<E4ProgressContext, CourseModuleTopic>
    {
        public CourseModuleTopicRepository(E4ProgressContext context, IMapper mapper) : base(mapper)
        {
            base. Context = context;
        }
    }
}
