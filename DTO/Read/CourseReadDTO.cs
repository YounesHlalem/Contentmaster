using System;

namespace DTO.Read
{
    public class CourseReadDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public int InstructionsLanguageId { get; set; }
        public virtual LanguageReadDTO InstructionsLanguage { get; set; }
        public int UserinterfaceLanguageId { get; set; }
        public virtual LanguageReadDTO UserinterfaceLanguage { get; set; }
        public int OfficeApplicationId { get; set; }
        public virtual OfficeApplicationReadDTO OfficeApplication { get; set; }
        public int CreatedBy { get; set; }
        public virtual UserReadDTO User { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Replicationkey { get; set; }
    }
}
