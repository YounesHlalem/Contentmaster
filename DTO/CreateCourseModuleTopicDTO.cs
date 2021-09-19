using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class CreateCourseModuleTopicDTO
    {
        public int Id { get; set; }
        public int ModuleId { get; set; }
        public string Title { get; set; }
        public int SortOrder { get; set; }

    }
}
