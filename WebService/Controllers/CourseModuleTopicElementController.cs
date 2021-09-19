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
    public class CourseModuleTopicElementController : ControllerBase
    {
        private readonly ICourseModuleTopicElementService CourseModuleTopicElementService;

        public CourseModuleTopicElementController(ICourseModuleTopicElementService courseModuleTopicElementService)
        {
            CourseModuleTopicElementService = courseModuleTopicElementService;
        }

        [HttpGet]
        public IEnumerable<CourseModuleTopicElementDTO> index()
        {
            return CourseModuleTopicElementService.GetAll();
        }

        [HttpGet("{id:int}")]
        public CourseModuleTopicElementDTO GetById(int id)
        {
            return CourseModuleTopicElementService.GetById(id);
        }

        [HttpPost]
        public void Create(CreateCourseModuleTopicElementDTO newCourseModuleTopicElementDTO)
        {
            CourseModuleTopicElementService.Create(newCourseModuleTopicElementDTO);
        }

        public void Update(CreateCourseModuleTopicElementDTO updateCourseModuleTopic)
        {
            CourseModuleTopicElementService.Update(updateCourseModuleTopic);
        }
    }
}
