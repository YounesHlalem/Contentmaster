namespace DTO
{
    public class CourseModuleTopicElementDTO
    {
        public int Id { get; set; }
        public int ContentElementTypeId { get; set; }
        public virtual ContentElementTypeDTO ContentElementType { get; set; }
        public int CourseModuleTopicId { get; set; }
        public virtual CourseModuleTopicDTO CourseModuleTopic { get; set; }
        public int ContentElementId { get; set; }
        public int DifficultyLevelId { get; set; }
        public virtual DifficultyLevelDTO DifficultyLevel { get; set; }
        public int Sortorder { get; set; }
    }
}
