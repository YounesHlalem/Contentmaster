using DTO.Read;
using DAL.Model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [CreateDTO(typeof(CourseModuleReadDTO))]
    public class CourseModule
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        public string Title { get; set; }
        public int Sortorder { get; set; }
    }
}
