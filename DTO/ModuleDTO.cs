using DTO.Read;

namespace DTO
{
    public class ModuleDTO
    {
        public int Id { get; set; }
        public CourseReadDTO course { get; set; }
        public string Title { get; set; }
        public int SortOrder { get; set; }

    }
}
