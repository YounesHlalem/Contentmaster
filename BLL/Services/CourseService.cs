using BLL.Interfaces;
using DAL.Context;
using DAL.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using DTO;
using DAL.Repository;
using System.IO;
using System.Drawing;
using DTO.Read;

namespace BLL.Services
{
    public class CourseService : ICourseService
    {
        private readonly E4ProgressContext _context;
        public DbSet<Course> dbSet { get; }
        public IMapper mapper { get; }
        private readonly CourseRepository CourseRepository;

        public CourseService(E4ProgressContext context, IMapper mapper)
        {
            this._context = context;
            this.dbSet = this._context.Courses;
            this.mapper = mapper;
            CourseRepository = new CourseRepository(mapper, context);
        }

        public List<CourseReadDTO> GetAll()
        {
            return CourseRepository.GetAll<CourseReadDTO>();
        }

        public CourseReadDTO GetById(object id)
        {
            return CourseRepository.FindBy<CourseReadDTO>(x => x.Id == (int)id).FirstOrDefault();
        }

        public void Create(CreateCourseDTO data)
        {
            if (!string.IsNullOrWhiteSpace(data.Image))
            {
                using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(data.Image)))
                {
                    using (Bitmap bm2 = new Bitmap(ms))
                    {
                        bm2.Save(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "icon", data.Icon));
                    }
                }
            }
            CourseRepository.Add(data);
        }

        public void Update(CreateCourseDTO data)
        {
            CourseRepository.Edit(data);
        }

        public void DeleteById(object id)
        {
            CourseRepository.Delete(x => x.Id == (int)id);
        }
    }
}
