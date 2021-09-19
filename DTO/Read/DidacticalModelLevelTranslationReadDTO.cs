namespace DTO.Read
{
    public class DidacticalModelLevelTranslationReadDTO
	{
        public int DidacticalModelLevelId { get; set; }
        public virtual DidacticalModelReadDTO DidacticalModelLevel { get; set; }
        public int LanguageId { get; set; }
        public virtual LanguageReadDTO Language { get; set; }
        public string Translation { get; set; }
    }
}