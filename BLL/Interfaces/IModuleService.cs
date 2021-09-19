using DAL.Model;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Interfaces
{
    public interface IModuleService : IBaseService<CourseModule, CreateModuleDTO, ModuleDTO>
    {
    }
}
