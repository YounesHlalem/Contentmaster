using DTO;
using DTO.Read;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface ICourseService : IBaseService<Course, CreateCourseDTO, CourseReadDTO>
    {
    }
}
