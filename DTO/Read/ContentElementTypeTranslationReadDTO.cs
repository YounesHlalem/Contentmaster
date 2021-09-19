namespace DTO.Read
{
    public class ContentElementTypeTranslationReadDTO
    {
        public int ContentElementTypeId { get; set; }
        public virtual ContentElementTypeReadDTO ContentElementType { get; set; }
        public int LanguageId { get; set; }
        public virtual LanguageReadDTO Language { get; set; }
        public string Translation { get; set; }
    }
}
