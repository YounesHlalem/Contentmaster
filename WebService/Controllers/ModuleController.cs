using BLL.Interfaces;
using DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ModuleController : ControllerBase
    {
        private readonly IModuleService moduleService;

        public ModuleController( IModuleService courseService)
        {
            this.moduleService = courseService;
        }

        [HttpGet]
        public IEnumerable<ModuleDTO> index()
        {
            return moduleService.GetAll();
        }

        [HttpGet("{id:int}")]
        public ModuleDTO GetById(int id)
        {
            return moduleService.GetById(id);
        }

        [HttpPost]
        public void Create(CreateModuleDTO newCourse)
        {
             moduleService.Create(newCourse);
        }

        [HttpPut]
        public void Update(CreateModuleDTO updateCourse)
        {
            /*User user = (User)HttpContext.Items["User"];
            if(courseService.GetAll().FirstOrDefault(item => item.Id == updateCourse.Id && item.CreatedBy == user.Id))
            {
                return;
            }*/
            moduleService.Update(updateCourse);
        }
    }
}
