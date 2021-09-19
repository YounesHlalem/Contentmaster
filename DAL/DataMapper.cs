using AutoMapper;
using DTO;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DAL.model.Attributes;

namespace DAL
{
    public class DataMapper : Profile
    {
        public static IEnumerable<Type> GetTypes(Assembly assembly, Type attribyte)
        {
            return from type in assembly.GetTypes()
                   where type.IsDefined(attribyte, false)
                   select type;
        }

        public DataMapper()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            // ReadDTOS
            {
                IEnumerable<Type> typesWithHelpAttribute = GetTypes(assembly, typeof(ReadDTOAttribute));
                var v = typesWithHelpAttribute.ToList();
                typesWithHelpAttribute.ToList().ForEach(x =>
                {
                    ReadDTOAttribute res = ReadDTOAttribute.GetAttribute(x);
                    CreateMap(x, res.Target).ReverseMap();
                });
            }

            /*CreateMap<Course, CourseReadDTO>().ReverseMap();
            CreateMap<Question, QuestionDTO>().ReverseMap();
            CreateMap<Quiz, QuizDTO>().ReverseMap();
            CreateMap<QuizQuestion, QuizQuestionDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();*/

            CreateMap<CreateCourseDTO, Course>().ReverseMap();
            // CreateMap<LangueDTO, Language>().ReverseMap();
            CreateMap<CreateQuizDTO, Quiz>().ReverseMap();
        }
    }
}
