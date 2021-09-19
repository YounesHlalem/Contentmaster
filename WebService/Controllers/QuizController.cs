using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DAL.Context;
using DAL.Repository;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DTO.Read;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly QuizRepository quizRepository;

        public QuizController(IMapper mapper, E4ProgressContext context)
        {
            quizRepository = new QuizRepository(mapper, context);
        }

        [HttpGet]
        public IEnumerable<QuizReadDTO> index()
        {
            return quizRepository.GetAll<QuizReadDTO>();
        }
    }
}
