using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DTO.Read;
using DAL.Model;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaticController : ControllerBase
    {
        private readonly E4ProgressContext context;
        private readonly IMapper mapper;

        public StaticController(E4ProgressContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("lang")]
        public List<LanguageReadDTO> GetLang()
        {
            
            return mapper.Map<List<LanguageReadDTO>>(context.Languages.ToList());
        }

        [HttpGet("app")]
        public List<OfficeApplicationReadDTO> GetApplciations()
        {
            return mapper.Map<List<OfficeApplicationReadDTO>>(context.OfficeApplications.ToList());
        }
    }
}
