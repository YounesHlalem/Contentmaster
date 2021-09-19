using DTO.Read;
using DAL.Model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [CreateDTO(typeof(CourseModuleTopicElementReadDTO))]
    public class CourseModuleTopicElement
    {
        public int Id { get; set; }
        public int ContentElementTypeId { get; set; }
        public virtual ContentElementType ContentElementType { get; set; }
        public int CourseModuleTopicId { get; set; }
        public virtual CourseModuleTopic CourseModuleTopic { get; set; }
        public int ContentElementId { get; set; }
        public int DifficultyLevelId { get; set; }
        public virtual DifficultyLevel DifficultyLevel { get; set; }
        public int Sortorder { get; set; }
    }
}
