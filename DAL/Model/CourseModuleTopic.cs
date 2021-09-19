using DTO.Read;
using DAL.model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [ReadDTOAttribute(typeof(CourseModuleTopicReadDTO))]
    public class CourseModuleTopic
    {
        public int Id { get; set; }
        public int CourseModuleId { get; set; }
        public virtual CourseModule CourseModule { get; set; }
        public string Title { get; set; }
        public int Sortorder { get; set; }
    }
}
