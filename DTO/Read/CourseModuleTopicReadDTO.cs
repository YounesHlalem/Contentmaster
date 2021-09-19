namespace DTO.Read
{
    public class CourseModuleTopicReadDTO
    {
        public int Id { get; set; }
        public int CourseModuleId { get; set; }
        public virtual CourseModuleReadDTO CourseModule { get; set; }
        public string Title { get; set; }
        public int Sortorder { get; set; }
    }
}
