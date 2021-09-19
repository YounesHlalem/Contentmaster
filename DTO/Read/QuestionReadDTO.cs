using System.Collections.Generic;

namespace DTO.Read
{
    public class QuestionReadDTO
    {
        public int Id { get; set; }
        public int QuestionTypeId { get; set; }
        public virtual QuestiontypeReadDTO Questiontype { get; set; }
        public bool IsMasterQuestion { get; set; }
        public int MasterQuestionId { get; set; }
        public virtual QuestionReadDTO MasterQuestion { get; set; }
        public int InstructionsLanguageId { get; set; }
        public virtual LanguageReadDTO InstructionsLanguage { get; set; }
        public int UserinterfaceLanguageId { get; set; }
        public virtual LanguageReadDTO UserinterfaceLanguage { get; set; }
        public int QuestionFormulationTypeId { get; set; }
        public virtual QuestionFormulationTypeReadDTO QuestionFormulationType { get; set; }
        public int OfficeApplicationId { get; set; }
        public virtual OfficeApplicationReadDTO OfficeApplication { get; set; }
        public string Title { get; set; }
        public string Questiontext { get; set; }
        public string Notes { get; set; }
        public int VersionNumber { get; set; }
        public string Replicationkey { get; set; }
        public List<QuizQuestionAnswerReadDTO> QuestionList { get; set; }
    }
}
