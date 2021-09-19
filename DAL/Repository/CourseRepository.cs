using AutoMapper;
using DAL.Context;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class CourseRepository : GenericRepository<E4ProgressContext, Course>
    {
        public CourseRepository(IMapper mapper, E4ProgressContext context) : base(mapper)
        {
            base.Context = context;
        }
    }
}
