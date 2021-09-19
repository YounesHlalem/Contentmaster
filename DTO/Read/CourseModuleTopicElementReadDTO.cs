namespace DTO.Read
{
    public class CourseModuleTopicElementReadDTO
    {
        public int Id { get; set; }
        public int ContentElementTypeId { get; set; }
        public virtual ContentElementTypeReadDTO ContentElementType { get; set; }
        public int CourseModuleTopicId { get; set; }
        public virtual CourseModuleTopicReadDTO CourseModuleTopic { get; set; }
        public int ContentElementId { get; set; }
        public int DifficultyLevelId { get; set; }
        public virtual DifficultyLevelReadDTO DifficultyLevel { get; set; }
        public int Sortorder { get; set; }
    }
}
