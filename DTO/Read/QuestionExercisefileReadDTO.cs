namespace DTO.Read
{
    public class QuestionExercisefileReadDTO
    {
        public int QuestionId { get; set; }
        public virtual QuestionReadDTO Question { get; set; }
        public int ExercisefileId { get; set; }
        public virtual ExercisefileReadDTO Exercisefile { get; set; }
    }
}
