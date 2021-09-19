namespace DTO.Read
{
    public class QuizQuestionAnswerReadDTO
    {
        public int QuizId { get; set; }
        public virtual QuizReadDTO Quiz { get; set; }
        public int QuestionId { get; set; }
        public virtual QuestionReadDTO Question { get; set; }
        public int QuestionAnswerId { get; set; }
        public virtual QuestionAnswerReadDTO QuestionAnswer { get; set; }
        public decimal Fraction { get; set; }
    }
}
