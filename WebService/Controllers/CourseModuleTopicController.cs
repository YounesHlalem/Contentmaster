using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO;
using BLL.Interfaces;


namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CourseModuleTopicController : ControllerBase
    {
        private readonly ICourseModuleTopicService CourseModuleTopicService;

        public CourseModuleTopicController( ICourseModuleTopicService courseModuleTopicService)
        {
            CourseModuleTopicService = courseModuleTopicService;
        }

        [HttpGet]
        public IEnumerable<CourseModuleTopicDTO> index()
        {
            return CourseModuleTopicService.GetAll();
        }

        [HttpGet("{id:int}")]
        public CourseModuleTopicDTO GetById(int id)
        {
            return CourseModuleTopicService.GetById(id);
        }

        [HttpPost]
        public void Create(CreateCourseModuleTopicDTO newCourseModuleTopicDTO)
        {
            CourseModuleTopicService.Create(newCourseModuleTopicDTO);
        }

        public void Update(CreateCourseModuleTopicDTO updateCourseModuleTopic)
        {

            CourseModuleTopicService.Update(updateCourseModuleTopic);
        }


    }
}
