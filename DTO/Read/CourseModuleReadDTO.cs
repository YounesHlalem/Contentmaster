namespace DTO.Read
{
    public class CourseModuleReadDTO
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public virtual CourseReadDTO Course { get; set; }
        public string Title { get; set; }
        public int Sortorder { get; set; }
    }
}
