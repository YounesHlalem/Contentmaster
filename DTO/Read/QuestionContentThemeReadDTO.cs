namespace DTO.Read
{
    public class QuestionContentThemeReadDTO
    {
        public int QuestionId { get; set; }
        public virtual QuestionReadDTO Question { get; set; }
        public int ContentThemeId { get; set; }
        public virtual ContentThemeReadDTO ContentTheme { get; set; }
    }
}
