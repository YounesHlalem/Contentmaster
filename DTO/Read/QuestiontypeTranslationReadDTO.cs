namespace DTO.Read
{
    public class QuestiontypeTranslationReadDTO
    {
        public int QuestiontypeId { get; set; }
        public virtual QuestiontypeReadDTO Questiontype { get; set; }
        public int LanguageId { get; set; }
        public virtual LanguageReadDTO Language { get; set; }
        public string Translation { get; set; }
    }
}
