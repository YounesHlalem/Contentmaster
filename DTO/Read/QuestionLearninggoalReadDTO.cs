namespace DTO.Read
{
    public class QuestionLearninggoalReadDTO
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public virtual QuestionReadDTO Question { get; set; }
        public int DidacticalModelLevelId { get; set; }
        public virtual DidacticalModelLevelReadDTO DidacticalModelLevel { get; set; }
        public string Learninggoal { get; set; }
        public bool IsMeasurable { get; set; }
        public string Notes { get; set; }
        public int SortOrder { get; set; }
    }
}