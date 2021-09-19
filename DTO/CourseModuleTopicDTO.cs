using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class CourseModuleTopicDTO
    {
        public int Id { get; set; }
        public ModuleDTO module { get; set; }
        public string Title { get; set; }
        public int SortOrder { get; set; }
    }
}
