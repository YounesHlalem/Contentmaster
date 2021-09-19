using AutoMapper;
using BLL.Interfaces;
using DAL.Context;
using DAL.Repository;
using DTO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using DAL.Model;

namespace BLL.Services
{
    public class CourseModuleTopicService : ICourseModuleTopicService
    {
        private readonly E4ProgressContext _context;
        private readonly CourseModuleTopicRepository courseModuleTopicRepository;
        public DbSet<CourseModuleTopic> dbSet { get; }
        public IMapper mapper { get; }
        public CourseModuleTopicService(E4ProgressContext context, IMapper mapper)
        {
            this._context = context;
            this.dbSet = _context.CourseModuleTopics;
        }

        public void Create(CreateCourseModuleTopicDTO data)
        {
            courseModuleTopicRepository.Add(data);
        }

        public void DeleteById(object id)
        {
            courseModuleTopicRepository.Delete(x => x.Id == (int)id);
        }

        public List<CourseModuleTopicDTO> GetAll()
        {
            return courseModuleTopicRepository.GetAll<CourseModuleTopicDTO>();
        }

        public CourseModuleTopicDTO GetById(object id)
        {
            return courseModuleTopicRepository.FindBy<CourseModuleTopicDTO>(x => x.Id == (int)id).FirstOrDefault();
        }

        public void Update(CreateCourseModuleTopicDTO data)
        {
            courseModuleTopicRepository.Edit(data);
        }
    }
}
