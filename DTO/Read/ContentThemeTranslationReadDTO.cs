namespace DTO.Read
{
    public class ContentThemeTranslationReadDTO
    {
        public int ContentThemeId { get; set; }
        public virtual ContentThemeReadDTO ContentTheme { get; set; }
        public int LanguageId { get; set; }
        public virtual LanguageReadDTO Language { get; set; }
        public string Translation { get; set; }
    }
}
