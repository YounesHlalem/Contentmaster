using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BLL;
using BLL.Interfaces;
using DAL.Context;
using DAL.Repository;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DTO.Read;
using DAL.Model;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CursusController : ControllerBase
    {
        private readonly CourseRepository CourseRepository;
        private readonly ICourseService courseService;

        public CursusController(IMapper mapper, E4ProgressContext context, ICourseService courseService)
        {
            this.courseService = courseService;
            CourseRepository = new CourseRepository(mapper, context);
        }

        [HttpGet]
        public IEnumerable<CourseReadDTO> index()
        {
            return courseService.GetAll();
        }

        [HttpGet("{id:int}")]
        public CourseReadDTO GetById(int id)
        {
            return courseService.GetById(id);
        }

        [HttpPost]
        public void Create(CreateCourseDTO newCourse)
        {
            User user = (User)HttpContext.Items["User"];
            newCourse.CreatedBy = user.Id;
            courseService.Create(newCourse);
        }

        [HttpPut]
        public void Update(CreateCourseDTO updateCourse)
        {
            User user = (User)HttpContext.Items["User"];
            var res = courseService.GetById(updateCourse.Id);
            var toCheck = user.Firstname + user.Lastname;
            if (res.User.Firstname + res.User.Lastname == toCheck)
            {
                updateCourse.CreatedBy = user.Id;
                courseService.Update(updateCourse);
            }
        }
    }
}
