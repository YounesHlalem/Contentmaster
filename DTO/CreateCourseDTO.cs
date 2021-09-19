using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class CreateCourseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public int InstructionsLanguageId { get; set; }
        public int UserinterfaceLanguageId { get; set; }
        public int OfficeApplicationId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Replicationkey { get; set; }
        public string Image { get; set; }
    }
}
