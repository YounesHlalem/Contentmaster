namespace DTO.Read
{
    public class DifficultyLevelTranslationReadDTO
    {
        public int DifficultyLevelId { get; set; }
        public virtual DifficultyLevelReadDTO DifficultyLevel { get; set; }
        public int LanguageId { get; set; }
        public virtual LanguageReadDTO Language { get; set; }
        public string Translation { get; set; }
    }
}
