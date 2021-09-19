using AutoMapper;
using BLL.Interfaces;
using DAL.Context;
using DAL.Model;
using DAL.Repository;
using DTO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BLL.Services
{
    public class ModuleService : IModuleService
    {
        private readonly E4ProgressContext _context;
        private readonly ModuleRepository moduleRepository;
        public DbSet<CourseModule> dbSet { get; }

        public IMapper mapper { get; }
        public ModuleService(E4ProgressContext context, IMapper mapper)
        {
            this._context = context;
            this.dbSet = _context.CourseModules;
            this.mapper = mapper;
            moduleRepository = new ModuleRepository(context, mapper);
        }

        public void Create(CreateModuleDTO data)
        {
            moduleRepository.Add(data);
        }

        public void DeleteById(object id)
        {
            moduleRepository.Delete(x => x.Id == (int)id);
        }

        public List<ModuleDTO> GetAll()
        {
            return moduleRepository.GetAll<ModuleDTO>();
        }

        public ModuleDTO GetById(object id)
        {
            return moduleRepository.FindBy<ModuleDTO>(x => x.Id == (int)id).FirstOrDefault();
        }

        public void Update(CreateModuleDTO data)
        {
            moduleRepository.Edit(data);
        }
    }
}
