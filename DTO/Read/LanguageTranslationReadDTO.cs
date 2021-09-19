namespace DTO.Read
{
    public class LanguageTranslationReadDTO
    {
        public int LanguageId { get; set; }
        public virtual LanguageReadDTO Language { get; set; }
        public int TranslationLanguageId { get; set; }
        public virtual LanguageReadDTO TranslationLanguage { get; set; }
        public string Translation { get; set; }
    }
}
