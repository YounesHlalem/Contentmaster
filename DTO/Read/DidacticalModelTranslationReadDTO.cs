namespace DTO.Read
{
    public class DidacticalModelTranslationReadDTO
    {
        public int DidacticalModelId { get; set; }
        public virtual DidacticalModelReadDTO DidacticalModel { get; set; }
        public int LanguageId { get; set; }
        public virtual LanguageReadDTO Language { get; set; }
        public string Translation { get; set; }
    }
}
