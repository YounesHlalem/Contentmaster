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
    public class CourseModeleTopicElementService : ICourseModuleTopicElementService
    {
        private readonly E4ProgressContext _context;
        private readonly CourseModuleTopicElementRepository courseModuleTopicElementRepository;
        public DbSet<CourseModuleTopicElement> dbSet { get; }

        public IMapper mapper { get; }

        public void Create(CreateCourseModuleTopicElementDTO data)
        {
            courseModuleTopicElementRepository.Add(data);
        }

        public void DeleteById(object id)
        {
            courseModuleTopicElementRepository.Delete(o => o.Id == (int)id);
        }

        public List<CourseModuleTopicElementDTO> GetAll()
        {
            return courseModuleTopicElementRepository.GetAll<CourseModuleTopicElementDTO>();
        }

        public CourseModuleTopicElementDTO GetById(object id)
        {
            return courseModuleTopicElementRepository.FindBy<CourseModuleTopicElementDTO>(x => x.Id == (int)id).FirstOrDefault();
        }

        public void Update(CreateCourseModuleTopicElementDTO data)
        {
            courseModuleTopicElementRepository.Edit(data);
        }
    }
}
