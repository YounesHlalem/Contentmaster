namespace DTO.Read
{
    public class QuestionPreKnowledgeSkillReadDTO
    {
        public int Id { get; set; }
        public string Skill { get; set; }
        public int QuestionId { get; set; }
        public virtual QuestionReadDTO Question { get; set; }
        public int SortOrder { get; set; }
    }
}
