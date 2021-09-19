namespace DTO
{
    public class CreateModuleDTO
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int SortOrder { get; set; }

    }
}
