namespace DTO.Read
{
    public class QuestionFormulationTypeTranslationReadDTO
	{
        public int QuestionFormulationTypeId { get; set; }
        public virtual QuestionFormulationTypeReadDTO QuestionFormulationType { get; set; }
        public int LanguageId { get; set; }
        public virtual LanguageReadDTO Language { get; set; }
        public string Translation { get; set; }
    }
}