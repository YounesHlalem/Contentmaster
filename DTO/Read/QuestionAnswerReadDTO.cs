namespace DTO.Read
{
    public class QuestionAnswerReadDTO
    {
        public int Id { get; set; }
        public int Questionid { get; set; }
        public virtual QuestionReadDTO Question { get; set; }
        public string Answer { get; set; }
    }
}
