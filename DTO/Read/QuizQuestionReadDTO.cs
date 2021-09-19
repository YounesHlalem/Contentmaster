namespace DTO.Read
{
    public class QuizQuestionReadDTO
    {
        public int QuizId { get; set; }
        public virtual QuizReadDTO Quiz { get; set; }
        public int QuestionId { get; set; }
        public virtual QuestionReadDTO Question { get; set; }
        public int Sortorder { get; set; }
    }
}
