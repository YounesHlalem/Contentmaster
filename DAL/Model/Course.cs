using DTO.Read;
using DAL.model.Attributes;
using DAL.Model.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Model
{
    [ReadDTOAttribute(typeof(CourseReadDTO))]
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public int InstructionsLanguageId { get; set; }
        public virtual Language InstructionsLanguage { get; set; }
        public int UserinterfaceLanguageId { get; set; }
        public virtual Language UserinterfaceLanguage { get; set; }
        public int OfficeApplicationId { get; set; }
        public virtual OfficeApplication OfficeApplication { get; set; }
        public int CreatedBy { get; set; }
        public virtual User User { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Replicationkey { get; set; }
    }
}
